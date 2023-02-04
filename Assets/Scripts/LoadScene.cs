using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string thisScene;
    public GameObject theCharacter;
    private GameObject theTimer;

    public void generalSceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void solSceneLoader(string sceneName) {
        theCharacter = GameObject.Find("Character");
        theTimer = GameObject.Find("TimerTest");
        DontDestroyOnLoad(GameObject.Find("SolGameStats"));
        SceneManager.LoadScene(sceneName);
        Destroy(theCharacter);
        //theTimer.GetComponent<Timer>().playing = true;
    }

    public void setDifficulty(string diff)
    {
        GameObject.Find("SolGameStats").GetComponent<SolGameStats>().gameDifficulty = diff;
    }
}
