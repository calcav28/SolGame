using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceMovement : MonoBehaviour
{
    public AudioClip playOnSuccess;
    public AudioClip playOnDeath;
    public int amountToAdd;

    void Awake()
    {
        amountToAdd = GameObject.Find("GlobalScripts").GetComponent<SolGameStats>().amountToAdd;
    }
    
    void Update()
    {
        transform.position = transform.position + new Vector3(0.4f * Time.deltaTime, 2.5f * Time.deltaTime, 0);
    }


    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject == GameObject.Find("Wall (3)") ||
            (coll.gameObject == GameObject.Find("Wall (2)")) ||
            (coll.gameObject == GameObject.Find("Wall (1)")) ||
            (coll.gameObject == GameObject.Find("Wall")))
        {
            GameObject.Find("PlayOnSuccess").GetComponent<AudioSource>().Play();
            GameObject.Find("Circle1").GetComponent<DestroyObject>().ballsHit += amountToAdd;
            Destroy(this.gameObject);
            //add to counter to display total amount of ships saved
        }
        else
        {
            GameObject.Find("PlayOnDestruction").GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }
}
