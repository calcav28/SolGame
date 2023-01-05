using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float timerTime;
    public int goodTimerTime;
    public bool playing;
    // Start is called before the first frame update
    void Start()
    {
        timerTime = 0.0f;
        goodTimerTime = 0;
        //playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Spawner1") != null) {
        timerTime += Time.deltaTime;
        }
        goodTimerTime = Mathf.FloorToInt(timerTime);
        timerText.text = goodTimerTime.ToString();

    }
}
