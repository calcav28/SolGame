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
    public GameObject characterObject;
    public int one;
    public int two;
    public int three;
    public int character;
    public int all;
    
    void Start() {
        circleOne = GameObject.Find("Circle1");
        circleTwo = GameObject.Find("OrbitCircle");
        circleThree = GameObject.Find("OrbitCircle (1)");
        characterObject = GameObject.Find("Character");
    }
    
    void Update()
    {
        one = circleOne.GetComponent<DestroyObject>().ballsHit;
        two = circleTwo.GetComponent<DestroyObject>().ballsHit;
        three = circleThree.GetComponent<DestroyObject>().ballsHit;
        character = characterObject.GetComponent<CharacterDestroyObject>().ballsHit;
        
        all = one + two + three + character;

        myText.text = all.ToString();
        
    }
}
