using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float moveSpeed;
    public Camera cam;
    public Vector3 mousePos;
    public Vector3 movePosition;
    public GameObject placeToMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Input.mousePosition;
            //Vector3 movePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));
            Vector3 movePosition = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));
            placeToMove.transform.position = movePosition;
        }
        transform.position = Vector3.MoveTowards(transform.position, placeToMove.transform.position, moveSpeed * Time.deltaTime);
    }
}
