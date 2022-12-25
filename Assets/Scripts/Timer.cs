using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float timerTime;
    public int goodTimerTime = 0;
    public bool playing;
    // Start is called before the first frame update
    void Start()
    {
        timerTime = 0.0f;
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing) {
        timerTime += Time.deltaTime;
        }
        goodTimerTime = Mathf.FloorToInt(timerTime);
        timerText.text = goodTimerTime.ToString();

    }
}
