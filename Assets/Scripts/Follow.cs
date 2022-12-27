using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public float moveSpeed;
    public GameObject objectToFollow;
    // Start is called before the first frame update
    void Start()
    {
        objectToFollow = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFollow.activeSelf) {
            Vector3 movement = objectToFollow.transform.position;            
            transform.position = Vector3.MoveTowards(transform.position, movement, moveSpeed * Time.deltaTime);
        } 
    }
}
