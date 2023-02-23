using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSkillShot : MonoBehaviour
{
    public bool offCooldown = true;
    public GameObject shotPrefab;
    public float shotSpeed;
    void Awake()
    {
        shotSpeed = 7.0f;
    }

    void Update()
    {
        Vector2 shotDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 shootPosition = new Vector2(mousePos.x, mousePos.y);
        //float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x)
        //    * Mathf.Rad2Deg - 90f;
        //transform.rotation = Quaternion.Euler(0, 0, angle);


        if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Q)) && offCooldown)
        {
            GameObject shot = Instantiate(shotPrefab, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody2D>().velocity = shootPosition.normalized * shotSpeed;
        }
    }
}
