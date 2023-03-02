using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreToText : MonoBehaviour
{
    public GameObject scoreObject;
    public TMP_Text highScoreText;
    public int theMainHighScore;
    public int thePreviousHighScore;
    
    void Start()
    {
        scoreObject = GameObject.Find("HighScoreTest");
        theMainHighScore = scoreObject.GetComponent<GetHighScore>().mainHighScore;
        thePreviousHighScore = scoreObject.GetComponent<GetHighScore>().prevHighScore;        
        
        if (theMainHighScore >= thePreviousHighScore) {
            highScoreText.text = theMainHighScore.ToString();
            scoreObject.GetComponent<GetHighScore>().prevHighScore = theMainHighScore;
        } else {
            highScoreText.text = thePreviousHighScore.ToString();
        }

    }
    
}
