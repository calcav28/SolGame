using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSkillShot : MonoBehaviour
{
    public bool offCooldown = true;
    public GameObject shotPrefab;
    public Transform firePoint;
    public float shotSpeed;
    public Vector2 previousMovePosition;
    public float fireForce = 20f;
    void Awake()
    {
        shotSpeed = 20.0f;
        fireForce = 20f;
    }

    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Q) || Input.GetMouseButtonDown(0)) && offCooldown)
        {
            //original code to mimic blitzcrank q skillshot
            //Invoke("resetMoveSpeed", 0.5f);
            //Invoke("useSkillShot", 0.25f);

            //trying as a normal shot, feels a lot better than above code
            Invoke("resetMoveSpeed", 0.1f);
            Invoke("useSkillShot", 0.01f);
        }

    }

    void resetMoveSpeed()
    {
        GameObject.Find("Character").GetComponent<MouseMovement>().canMove = true;
        GameObject.Find("Character").GetComponent<MouseMovement>().placeToMove.transform.position = previousMovePosition;
    }

    void useSkillShot()
    {
        //stops player from moving after shooting
        GameObject.Find("Character").GetComponent<MouseMovement>().canMove = false;
        previousMovePosition = GameObject.Find("Character").GetComponent<MouseMovement>().movePosition;
        
        Vector2 shotDirection = Input.mousePosition;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(shotDirection);
        Vector2 shootPosition = new Vector2(mousePos.x, mousePos.y);
        shootPosition.Normalize();
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x)
            * Mathf.Rad2Deg - 90f;
        
        GameObject.Find("Character").GetComponent<MouseMovement>().placeToMove.transform.position = this.transform.position;
        
        GameObject shot = Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
        shot.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }
}
