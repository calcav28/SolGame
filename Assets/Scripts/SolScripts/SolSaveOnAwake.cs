using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolSaveOnAwake : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        //adds points gained from played game to total solProPoints
        GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solProPoints += 
        GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all;

        //adds points gained from played game to total superPoints
        GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerStats>().superPoints += 
        GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all;
    }
}
