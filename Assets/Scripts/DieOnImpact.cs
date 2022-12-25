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
    
    void OnCollisionEnter2D(Collision2D collision) {
        SceneManager.LoadScene("DeathScreen");
        DontDestroyOnLoad(charac);
        DontDestroyOnLoad(ourTime);
    }
}
