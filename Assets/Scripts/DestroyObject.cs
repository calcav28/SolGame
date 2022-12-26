using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int ballsHit = 0;
    public bool canBeInvulnerable; 
    public GameObject aaaa;

    void Start() {
        aaaa = GameObject.Find("Character");
        //canBeInvulnerable = aaaa.GetComponent<DieOnImpact>().isInvulnerable;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (gameObject == GameObject.Find("Character")) {
            canBeInvulnerable = aaaa.GetComponent<DieOnImpact>().isInvulnerable;
        }
        if ((coll.gameObject != GameObject.Find("Wall (3)")) && 
            (coll.gameObject != GameObject.Find("Wall (2)")) && 
            (coll.gameObject != GameObject.Find("Wall (1)")) &&
            (coll.gameObject != GameObject.Find("Wall")) &&
            (coll.gameObject != GameObject.Find("Character")) &&
            (coll.gameObject != GameObject.Find("InvulnerabilityCircle")) &&
            (coll.gameObject != GameObject.Find("Circle1")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle (1)")) &&
            !canBeInvulnerable)
        {
            Destroy(coll.gameObject);
            ballsHit += 1;
        }
    }
    public int getBallsHit() {
        return ballsHit;
    }
}
