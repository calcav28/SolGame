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
    public GameObject characterObject;
    private int one;
    private int two;
    private int three;
    private int character;
    private int all;
    public int mainHighScore;
    public int prevHighScore;

    void Start()
    {
        mainHighScore = 0;
        prevHighScore = 0;
    }

    void Update()
    {
        circleFirst = GameObject.Find("Circle1");
        circleSecond = GameObject.Find("OrbitCircle");
        circleThird = GameObject.Find("OrbitCircle (1)");
        characterObject = GameObject.Find("Character");
        
        one = circleFirst.GetComponent<DestroyObject>().ballsHit;
        two = circleSecond.GetComponent<DestroyObject>().ballsHit;
        three = circleThird.GetComponent<DestroyObject>().ballsHit;
        character = characterObject.GetComponent<CharacterDestroyObject>().ballsHit;
        
        all = one + two + three + character;
        GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solProPoints = all;
        GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerStats>().superPoints = all;

        //change text based on difficulty

        if (all >= prevHighScore) {
            mainHighScore = all;
        }

    }
}
