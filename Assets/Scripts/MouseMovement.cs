using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float moveSpeed;
    public Camera cam;
    public Rigidbody2D rb;
    public GameObject placeToMove;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
        transform.position = Vector3.MoveTowards(rb.position, placeToMove.transform.position, moveSpeed * Time.deltaTime);
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector2 movePosition = new Vector2(mousePos.x, mousePos.y);
            placeToMove.transform.position = movePosition;
        }
    }
}
