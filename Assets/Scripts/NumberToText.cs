using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberToText : MonoBehaviour
{
    public TMP_Text myText;
    public int ballsTotal;
    public GameObject circleOne;
    public GameObject circleTwo;
    public GameObject circleThree;
    public int one;
    public int two;
    public int three;
    public int all;
    public int mainHighScore;
    public TMP_Text highScoreText;

    
    void Start() {
        circleOne = GameObject.Find("Circle1");
        circleTwo = GameObject.Find("OrbitCircle");
        circleThree = GameObject.Find("OrbitCircle (1)");
        mainHighScore = 0;
    }
    
    // Update is called once per frame
    void Update()
    {


        one = circleOne.GetComponent<DestroyObject>().ballsHit;
        two = circleTwo.GetComponent<DestroyObject>().ballsHit;
        three = circleThree.GetComponent<DestroyObject>().ballsHit;
        
        all = one + two + three;

        myText.text = all.ToString();
        
        if (all >= mainHighScore) {
            mainHighScore = all;
        }
        
        highScoreText.text = mainHighScore.ToString();

    }
}
