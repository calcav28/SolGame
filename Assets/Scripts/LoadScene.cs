using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string thisScene;
    public GameObject theCharacter;
    private GameObject theTimer;
    public void sceneLoader(string sceneName) {
        theCharacter = GameObject.Find("Character");
        theTimer = GameObject.Find("TimerTest");
        //thisScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
        Destroy(theCharacter);
        theTimer.GetComponent<Timer>().playing = true;
        DontDestroyOnLoad(GameObject.Find("SolGameStats"));
    }
}
