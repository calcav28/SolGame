using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbilityTimerToText : MonoBehaviour
{
    public float eNumber = 10;
    public float rNumber = 10;
    public float tNumber = 15;
    public GameObject circleDude;
    public TMP_Text displayText;
    public string compareText;
    // Start is called before the first frame update
    void Start()
    {
        compareText = displayText.text;
        eNumber = 10;
        rNumber = 10;
        tNumber = 15;
    }

    // Update is called once per frame
    void Update()
    {
        eNumber = circleDude.GetComponent<RotateAroundPoint>().ballSizeTimer;
        eNumber = Mathf.FloorToInt(eNumber);
        if (eNumber >= 10) {
            eNumber = 10;
        }
        
        rNumber = circleDude.GetComponent<RotateAroundPoint>().ballSpeedTimer;
        rNumber = Mathf.FloorToInt(rNumber);
        if (rNumber >= 10) {
            rNumber = 10;
        }
        tNumber = circleDude.GetComponent<RotateAroundPoint>().ballUltTimer;
        tNumber = Mathf.FloorToInt(tNumber);
        if (tNumber >= 15) {
            tNumber = 15;
        }

        switch(compareText)
        {
        case "2ETime": 
            if (eNumber == 10) {
                displayText.text = "Ready!";
            } else {
                displayText.text = eNumber.ToString();
            }
            break;

        case "3RTime":
            if (rNumber == 10) {
                displayText.text = "Ready!";
            } else {
                displayText.text = rNumber.ToString();
            }
            break;

        case "4TTime":
            if (tNumber == 15) {
                displayText.text = "Ready!";
            } else {
                displayText.text = tNumber.ToString();
            }
            break;

        }
        
    }
}
