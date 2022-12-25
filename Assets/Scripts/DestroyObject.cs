using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int ballsHit = 0;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject != GameObject.Find("Wall (3)")) && 
            (coll.gameObject != GameObject.Find("Wall (2)")) && 
            (coll.gameObject != GameObject.Find("Wall (1)")) &&
            (coll.gameObject != GameObject.Find("Wall")))
        {
            Destroy(coll.gameObject);
            ballsHit += 1;
        }
    }
    public int getBallsHit() {
        return ballsHit;
    }
}
