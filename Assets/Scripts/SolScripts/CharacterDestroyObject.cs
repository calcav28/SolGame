using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDestroyObject : MonoBehaviour
{
    public int ballsHit = 0;
    public bool isInvulnerable;

    void Update() {
        isInvulnerable = GameObject.Find("Character").GetComponent<DieOnImpact>().isInvulnerable;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject != GameObject.Find("Wall (3)")) && 
            (coll.gameObject != GameObject.Find("Wall (2)")) && 
            (coll.gameObject != GameObject.Find("Wall (1)")) &&
            (coll.gameObject != GameObject.Find("Wall")) &&
            (coll.gameObject != GameObject.Find("Character")) &&
            (coll.gameObject != GameObject.Find("Circle1")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle (1)")) &&
            isInvulnerable)
        {
            if (coll.gameObject.tag != "Friend")
            {
                Destroy(coll.gameObject);
                ballsHit += 1;
            }
            Destroy(coll.gameObject);
        }
    }
}
