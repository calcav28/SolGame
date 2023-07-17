using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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



        //handles setting high score depending on difficulty
        switch (GameObject.Find("GlobalScripts").GetComponent<SolGameStats>().gameDifficulty)
        {
            case "easy":
                if (GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solEasyHighScore <
                    GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all)
                {
                    GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solEasyHighScore =
                    GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all;
                }
                break;

            case "medium":
                if (GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solMedHighScore <
                    GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all)
                {
                    GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solMedHighScore =
                    GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all;
                }
                break;
            case "hard":
                if (GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHardHighScore <
                    GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all)
                {
                    GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHardHighScore =
                    GameObject.Find("HighScoreTest").GetComponent<GetHighScore>().all;
                }
                break;
        }

        GameObject.Find("EasyHighScoreNumber").GetComponent<TMP_Text>().text = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solEasyHighScore.ToString();
        GameObject.Find("MediumHighScoreNumber").GetComponent<TMP_Text>().text = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solMedHighScore.ToString();
        GameObject.Find("HardHighScoreNumber").GetComponent<TMP_Text>().text = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHardHighScore.ToString();

        //saves everything
        GameObject.Find("GlobalScripts").GetComponent<SaveLoadSystem>().saveToJson();
    }
}
