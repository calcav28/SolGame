using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb;
    public GameObject placeToMove;
    public bool canMove;
    public Vector2 movePosition;
    void Awake()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.position = Vector3.MoveTowards(rb.position, placeToMove.transform.position, moveSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            movePosition = new Vector2(mousePos.x, mousePos.y);
            placeToMove.transform.position = movePosition;
        }
    }

    void FixedUpdate()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 aimDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x)
            * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
