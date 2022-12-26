using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    public GameObject scoreObject;
    public TMP_Text highScoreText;
    public int scoreHere;
    public int highScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("HighScoreTest");
    }

    // Update is called once per frame
    void Update()
    {
        scoreHere = scoreObject.GetComponent<NumberToText>().mainHighScore;
        highScoreText.text = highScore.ToString();
    }
    
}
