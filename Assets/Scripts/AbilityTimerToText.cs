using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbilityTimerToText : MonoBehaviour
{
    public float eNumber = 10;
    public float rNumber = 10;
    public float tNumber = 15;
    public float eNumberCountdown;
    public float rNumberCountdown;
    public float tNumberCountdown;
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
        eNumberCountdown = 10;
        rNumberCountdown = 10;
        tNumberCountdown = 15;
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

        eNumberCountdown = circleDude.GetComponent<RotateAroundPoint>().ballSizeCooldown;
        eNumberCountdown -= eNumber;
        rNumberCountdown = circleDude.GetComponent<RotateAroundPoint>().ballSpeedCooldown;
        rNumberCountdown -= rNumber;
        tNumberCountdown = circleDude.GetComponent<RotateAroundPoint>().ballUltCooldown;
        tNumberCountdown -= tNumber;

        switch (compareText)
        {
        case "2ETime": 
            if (eNumber == 10) {
                displayText.text = "Ready!";
            } else {
                    eNumberCountdown = Mathf.FloorToInt(eNumberCountdown);
                    displayText.text = eNumberCountdown.ToString();
            }
            break;

        case "3RTime":
            if (rNumber == 10) {
                displayText.text = "Ready!";
            } else {
                    rNumberCountdown = Mathf.FloorToInt(rNumberCountdown);
                    displayText.text = rNumberCountdown.ToString();
            }
            break;

        case "4TTime":
            if (tNumber == 15) {
                displayText.text = "Ready!";
            } else {
                    tNumberCountdown = Mathf.FloorToInt(tNumberCountdown);
                    displayText.text = tNumberCountdown.ToString();
            }
            break;

        }
        
    }
}
