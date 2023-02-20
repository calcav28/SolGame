using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float moveSpeed;
    public Camera cam;
    public Rigidbody2D rb;
    public GameObject placeToMove;
    //public GameObject placeToMove;
    // Start is called before the first frame update
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
            //Vector3 movePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));
            Vector2 movePosition = new Vector2(mousePos.x, mousePos.y);
            //placeToMove.MovePosition(Vector2.MoveTowards(rb.position, movePosition, moveSpeed * Time.deltaTime));
            placeToMove.transform.position = movePosition;
        }
        //transform.position = Vector2.MoveTowards(transform.position, placeToMove.transform.position, moveSpeed * Time.deltaTime);
    }
}
