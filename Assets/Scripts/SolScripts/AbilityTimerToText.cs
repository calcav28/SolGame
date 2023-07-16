using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AbilityTimerToText : MonoBehaviour
{
    public float eNumber = 10;
    public float rNumber = 10;
    public float fNumber = 15;
    public float eNumberCountdown;
    public float rNumberCountdown;
    public float fNumberCountdown;
    public float eNumberCooldown;
    public float rNumberCooldown;
    public float fNumberCooldown;
    public GameObject circleDude;
    public TMP_Text displayText;
    public string compareText;

    void Awake()
    {
        compareText = displayText.text;
        eNumber = 10;
        rNumber = 10;
        fNumber = 15;
        eNumberCountdown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballSizeCooldown;
        eNumberCooldown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballSizeCooldown;
        rNumberCountdown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballSpeedCooldown;
        rNumberCooldown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballSpeedCooldown;
        fNumberCountdown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballUltCooldown;
        fNumberCooldown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballUltCooldown;
    }

    void Update()
    {
        eNumber = circleDude.GetComponent<RotateAroundPoint>().ballSizeTimer;
        eNumber = Mathf.FloorToInt(eNumber);
        if (eNumber >= eNumberCooldown) {
            eNumber = eNumberCooldown;
        }
        
        rNumber = circleDude.GetComponent<RotateAroundPoint>().ballSpeedTimer;
        rNumber = Mathf.FloorToInt(rNumber);
        if (rNumber >= rNumberCooldown) {
            rNumber = rNumberCooldown;
        }
        fNumber = circleDude.GetComponent<RotateAroundPoint>().ballUltTimer;
        fNumber = Mathf.FloorToInt(fNumber);
        if (fNumber >= fNumberCooldown) {
            fNumber = fNumberCooldown;
        }

        eNumberCountdown = circleDude.GetComponent<RotateAroundPoint>().ballSizeCooldown;
        eNumberCountdown -= eNumber;
        rNumberCountdown = circleDude.GetComponent<RotateAroundPoint>().ballSpeedCooldown;
        rNumberCountdown -= rNumber;
        fNumberCountdown = circleDude.GetComponent<RotateAroundPoint>().ballUltCooldown;
        fNumberCountdown -= fNumber;

        switch (compareText)
        {
        case "2ETime": 
            if (eNumber == 10) {
                displayText.text = "";
            } else {
                    eNumberCountdown = Mathf.FloorToInt(eNumberCountdown);
                    displayText.text = eNumberCountdown.ToString();
            }
            break;

        case "3RTime":
            if (rNumber == 10) {
                displayText.text = "";
            } else {
                    rNumberCountdown = Mathf.FloorToInt(rNumberCountdown);
                    displayText.text = rNumberCountdown.ToString();
            }
            break;

        case "4FTime":
            if (fNumber == 15) {
                displayText.text = "";
            } else {
                    fNumberCountdown = Mathf.FloorToInt(fNumberCountdown);
                    displayText.text = fNumberCountdown.ToString();
            }
            break;

        }
        
    }
}
