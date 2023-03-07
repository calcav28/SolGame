using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDestroyObject : MonoBehaviour
{
    public GameObject thisBall;
    public float shotSpeed = 20;
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject != GameObject.Find("Wall (3)")) &&
            (coll.gameObject != GameObject.Find("Wall (2)")) &&
            (coll.gameObject != GameObject.Find("Wall (1)")) &&
            (coll.gameObject != GameObject.Find("Wall")) &&
            (coll.gameObject != GameObject.Find("Character")))
        {
            Destroy(coll.gameObject);
            //ballsHit += 1;
        }
        Destroy(thisBall);
    }
}
