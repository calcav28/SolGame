using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieOnImpact : MonoBehaviour
{
    public GameObject charac;
    public GameObject ourTime;
    
    void Start() {
        charac = GameObject.Find("Character");
        ourTime = GameObject.Find("TimerTest");
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if ((coll.gameObject != GameObject.Find("Wall (3)")) && 
            (coll.gameObject != GameObject.Find("Wall (2)")) && 
            (coll.gameObject != GameObject.Find("Wall (1)")) &&
            (coll.gameObject != GameObject.Find("Wall"))) 
        {
            SceneManager.LoadScene("DeathScreen");
            DontDestroyOnLoad(charac);
            DontDestroyOnLoad(ourTime);
        }
    }
}
