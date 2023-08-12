using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string thisScene;
    public GameObject theCharacter;
    private GameObject theTimer;

    //when stuff starts to break with loading scenes and stuff (especially loading back to the title screen),
    //you will need to implement the singleton pattern to ensure stuff doesn't break
    public void generalSceneLoader(string sceneName)
    {
        theCharacter = GameObject.Find("Character");
        Destroy(theCharacter);
        DontDestroyOnLoad(GameObject.Find("GlobalScripts"));
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }


    public void solSceneLoader(string sceneName) {
        theCharacter = GameObject.Find("Character");
        theTimer = GameObject.Find("TimerTest");
        Destroy(theCharacter);
        DontDestroyOnLoad(GameObject.Find("GlobalScripts"));
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
        //theTimer.GetComponent<Timer>().playing = true;
    }

    public void setDifficulty(string diff)
    {
        GameObject.Find("GlobalScripts").GetComponent<SolGameStats>().gameDifficulty = diff;
        DontDestroyOnLoad(GameObject.Find("GlobalScripts"));
    }


}
