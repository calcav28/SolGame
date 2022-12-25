using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenScore : MonoBehaviour
{
    private int theNumber;
    private TMP_Text thisText;
    private GameObject scoreThing;
    private GameObject timeThing;
    // Start is called before the first frame update
    void Start()
    {
        scoreThing = GameObject.Find("ScoreNumber");
        theNumber = GetComponent<NumberToText>().all;
        thisText.text = theNumber.ToString();
    }

}
