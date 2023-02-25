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
        //Vector2 shotDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 shotDirection = Input.mousePosition;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootPosition = new Vector2(mousePos.x, mousePos.y);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x)
            * Mathf.Rad2Deg - 90f;
        //transform.localRotation = Quaternion.Euler(0, 0, angle);


        if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Q)) && offCooldown)
        {
            GameObject shot = Instantiate(shotPrefab, transform.position, Quaternion.Euler(0, 0, angle));
            shot.GetComponent<Rigidbody2D>().velocity = shootPosition.normalized * shotSpeed;
        }
    }
}
