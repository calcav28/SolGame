using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbilityDurationToText : MonoBehaviour
{
    public int duration;
    public float timeToSubtract;
    public TMP_Text myText;
    public KeyCode keyWanted;
    public KeyCode keyWanted2;
    public bool abilityUsed;
    // Start is called before the first frame update
    void Start()
    {
        duration = 5;
        timeToSubtract = 0;
        myText.enabled = false;
        abilityUsed = false;
    }

    // Update is called once per frame
    void Update()
    {
        //abilityUsed = GameObject.Find("Character").GetComponent<RotateAroundPoint>();
        if ((Input.GetKeyDown(keyWanted) || Input.GetKeyDown(keyWanted2))) {
            myText.enabled = true;
            Invoke("TimerDown", 0f);
    }
}

    
    public void TimerDown() {
        myText.text = "Time Remaining: 5";
        Invoke("Timer4", 1);
    }

    public void Timer4() {
        myText.text = "Time Remaining: 4";
        Invoke("Timer3", 1);
    }

    public void Timer3() {
        myText.text = "Time Remaining: 3";
        Invoke("Timer2", 1);
    }

    public void Timer2() {
        myText.text = "Time Remaining: 2";
        Invoke("Timer1", 1);
    }

    public void Timer1() {
        myText.text = "Time Remaining: 1";
        Invoke("Timer0", 1);
    }

    public void Timer0() {
        myText.text = "Time Remaining: 0";
        myText.enabled = false;
    }

}

