using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieOnImpact : MonoBehaviour
{
    public GameObject charac;
    public GameObject ourTime;
    public GameObject theHighScore;
    
    void Start() {
        charac = GameObject.Find("Character");
        ourTime = GameObject.Find("TimerTest");
        theHighScore = GameObject.Find("HighScoreTest");
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if ((coll.gameObject != GameObject.Find("Wall (3)")) && 
            (coll.gameObject != GameObject.Find("Wall (2)")) && 
            (coll.gameObject != GameObject.Find("Wall (1)")) &&
            (coll.gameObject != GameObject.Find("Wall")) &&
            (coll.gameObject != GameObject.Find("Character")) &&
            (coll.gameObject != GameObject.Find("InvulnerabilityCircle")) &&
            (coll.gameObject != GameObject.Find("Circle1")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle")) &&
            (coll.gameObject != GameObject.Find("OrbitCircle (1)")))
        {
            SceneManager.LoadScene("DeathScreen");
            DontDestroyOnLoad(charac);
            DontDestroyOnLoad(ourTime);
            DontDestroyOnLoad(theHighScore);
        }
    }
}
