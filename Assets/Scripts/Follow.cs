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
        
    }

    // Update is called once per frame
    void Update()
    {
        objectToFollow = GameObject.Find("Character");
        Vector3 movement = objectToFollow.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, movement, moveSpeed * Time.deltaTime);
    }
}
