using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public float moveSpeed;
    public GameObject objectToFollow;


    void Update()
    {
        objectToFollow = GameObject.Find("Character");
        moveSpeed = GameObject.Find("GlobalScripts").GetComponent<SolGameStats>().enemyCircleSpeed;

      //  if (objectToFollow.activeSelf) {
            Vector3 movement = objectToFollow.transform.position;            
            transform.position = Vector3.MoveTowards(transform.position, movement, moveSpeed * Time.deltaTime);
//        } 
    }
}
