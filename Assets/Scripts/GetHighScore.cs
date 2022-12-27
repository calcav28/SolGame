using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetHighScore : MonoBehaviour
{

    public TMP_Text theText;
    public GameObject circleFirst;
    public GameObject circleSecond;
    public GameObject circleThird;
    private int one;
    private int two;
    private int three;
    private int all;
    public int mainHighScore;
    public int prevHighScore;
    // Start is called before the first frame update
    void Start()
    {
        mainHighScore = 0;
        prevHighScore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        circleFirst = GameObject.Find("Circle1");
        circleSecond = GameObject.Find("OrbitCircle");
        circleThird = GameObject.Find("OrbitCircle (1)");
        
        one = circleFirst.GetComponent<DestroyObject>().ballsHit;
        two = circleSecond.GetComponent<DestroyObject>().ballsHit;
        three = circleThird.GetComponent<DestroyObject>().ballsHit;
        
        all = one + two + three;

        if (all >= prevHighScore) {
            mainHighScore = all;
        }

        theText.text = mainHighScore.ToString();
    }
}
