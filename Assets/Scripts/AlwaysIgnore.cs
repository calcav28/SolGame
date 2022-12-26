using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysIgnore : MonoBehaviour
{
    public GameObject character1;
    public GameObject invCircle;
    public Collider charCollision;
    public Collider circleCollision;
    // Start is called before the first frame update
    void Start()
    {
        character1 = GameObject.Find("Character");
        invCircle = GameObject.Find("InvulnerabilityCircle");
        charCollision = character1.GetComponent<Collider>();
        circleCollision = invCircle.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(charCollision, circleCollision);
    }
}
