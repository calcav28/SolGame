using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolMovement : MonoBehaviour
{
    public bool wasdMovement;
    public float moveSpeed;
    public Rigidbody2D rb;
    public GameObject placeToMove;
    public Vector2 movePosition;

    void Update()
    {
        wasdMovement = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().wasdMovement;
        if (wasdMovement) {
            keyboardMovement();
        } else {
            transform.position = Vector3.MoveTowards(rb.position, placeToMove.transform.position, moveSpeed * Time.deltaTime);
            mouseMovement();
        }
    }

    void keyboardMovement()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + movement * moveSpeed * Time.deltaTime;
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    void mouseMovement()
    {
        if (Input.GetMouseButtonDown(1)) {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            movePosition = new Vector2(mousePos.x, mousePos.y);
            placeToMove.transform.position = movePosition;
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
