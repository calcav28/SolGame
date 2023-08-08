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
            (coll.gameObject != GameObject.Find("Wall")) &&
            (coll.gameObject != GameObject.Find("Character")) &&
            (coll.gameObject != GameObject.Find("Circle1")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle (1)")))
        {
            if (coll.gameObject.tag != "Friend")
            {
                this.GetComponent<AudioSource>().Play(0);
                Destroy(coll.gameObject);
                ballsHit += 1;
            }
            //GameObject.Find("PlayOnDestruction").GetComponent<AudioSource>().Play();
            Destroy(coll.gameObject);
        }
    }
}
