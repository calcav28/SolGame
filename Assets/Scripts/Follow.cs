using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public float moveSpeed;
    public GameObject objectToFollow;
    public GameObject invuCircle;
    // Start is called before the first frame update
    void Start()
    {
        objectToFollow = GameObject.Find("Character");
        invuCircle = GameObject.Find("InvulnerabilityCircle");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (objectToFollow.activeSelf) {
            Vector3 movement = objectToFollow.transform.position;            
            transform.position = Vector3.MoveTowards(transform.position, movement, moveSpeed * Time.deltaTime);
        } 

        if (!objectToFollow.activeSelf) {
            Vector3 invMovement = invuCircle.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, invMovement, moveSpeed * Time.deltaTime);
        }
    }

    //invuCircle.activeSelf
}
