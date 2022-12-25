using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeToText : MonoBehaviour
{
    public GameObject timerThing;
    public TMP_Text timerText;
    public int timee;
    // Start is called before the first frame update
    void Start()
    {
        timerThing = GameObject.Find("TimerTest");
        timerThing.GetComponent<Timer>().playing = false;
        timee = timerThing.GetComponent<Timer>().goodTimerTime;
        timerText.text = timee.ToString();
        timerThing.GetComponent<Timer>().timerTime = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
