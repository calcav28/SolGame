using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndTimeScore : MonoBehaviour
{
    private int theTime = 0;
    private TMP_Text theText;
    private GameObject giveTheScoreBaby;
    
    void Start()
    {
        giveTheScoreBaby = GameObject.Find("TimerTest");
        theTime = giveTheScoreBaby.GetComponent<Timer>().goodTimerTime;
    }

    void Update() {
        theText.text = theTime.ToString();
    }

}
