using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeToText : MonoBehaviour
{
    public TMP_Text timerText;
    public int timeToText;

    void Start()
    {
        GameObject.Find("TimerTest").GetComponent<Timer>().playing = false;
        timeToText = GameObject.Find("TimerTest").GetComponent<Timer>().goodTimerTime;
        timerText.text = timeToText.ToString();
        GameObject.Find("TimerTest").GetComponent<Timer>().timerTime = 0;
    }
}
