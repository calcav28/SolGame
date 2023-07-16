using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script handles the circles rotating around the player alongside abilities for player 

public class RotateAroundPoint : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject pivotObject;
    public float ballSizeTimer;
    public float ballSpeedTimer;
    public float ballUltTimer;
    public float ballSizeCooldown;
    public float ballSpeedCooldown;
    public float ballUltCooldown;
    public bool usedAbility = false;
    public bool hasQ;
    public bool hasE;
    public bool hasR;
    public bool hasF;
    public bool hasQUpgrade;
    public bool hasEUpgrade;
    public bool hasRUpgrade;
    public bool hasFUpgrade;


    
    void Awake()
    {
        //handle getting keybinds for player plus booleans for abilities


        //abilities:

        hasQ = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasQAbility;
        hasE = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasEAbility;
        hasR = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasRAbility;
        hasF = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasFAbility;



        //ability upgrades:

        hasQUpgrade = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasQUpgrade;
        hasEUpgrade = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasEUpgrade;
        hasRUpgrade = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasRUpgrade;
        hasFUpgrade = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasFUpgrade;



        if (hasEUpgrade)
        {
            ballSizeTimer = 10;
            ballSizeCooldown = 10;
        } else
        {
            ballSizeTimer = 30;
            ballSizeCooldown = 30;
        }

        if (hasRUpgrade)
        {
            ballSpeedTimer = 10;
            ballSpeedCooldown = 10;
        } else
        {
            ballSpeedTimer = 30;
            ballSpeedCooldown = 30;
        }

        if (hasFUpgrade)
        {
            ballUltTimer = 15; 
            ballUltCooldown = 15;
        } else
        {
            ballUltTimer = 45;
            ballUltCooldown = 45;
        }

        //keybinds:
    }

    void Update()
    {
        
        //rotates object around point
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
        
        //handles timers for abilities
        ballSizeTimer += Time.deltaTime;
        ballSpeedTimer += Time.deltaTime;
        ballUltTimer += Time.deltaTime;
        

        //eventually change to implement keybind system
        
        //changes rotation, 1/Q
        if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Q)) && hasQ) {
            rotationSpeed = rotationSpeed * -1.0f;
        }

        //makes balls bigger, 2/E
        if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.E)) && hasE
            && ballSizeTimer >= ballSizeCooldown) {
            usedAbility = true;
            ballSizeTimer = 0;
            gameObject.transform.localScale += new Vector3(1.25f, 1.25f, 1f);
            Invoke("resetUsedAbility", 0.00001f);
            Invoke("resetBallSize", 5.0f);
        }

        //makes balls rotate faster, 3/R
        if ((Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.R)) && hasR
            && ballSpeedTimer >= ballSpeedCooldown) {
            usedAbility = true;
            ballSpeedTimer = 0;
            rotationSpeed = rotationSpeed * 2.0f;
            Invoke("resetUsedAbility", 0.00001f);
            Invoke("resetBallSpeed", 5.0f);
        }
        
        //ultimate ability, 4/F,
        if ((Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.F)) && hasF
            && ballUltTimer >= ballUltCooldown) {
            usedAbility = true;
            ballUltTimer = 0;
            rotationSpeed = rotationSpeed * 2.5f;
            gameObject.transform.localPosition *= 1.25f;
            gameObject.transform.localScale += new Vector3(1.25f, 1.25f, 1f);
            Invoke("resetUsedAbility", 0.00001f);            
            Invoke("resetBallUlt", 5.0f);
        }
    }

    //resets boolean for timers
    private void resetUsedAbility() {
        usedAbility = false;
    }

    //resets scale 
    private void resetBallSize() {
        gameObject.transform.localScale += new Vector3(-1.25f, -1.25f, -1f);
    }

    //resets rotation speed
    private void resetBallSpeed() {
        rotationSpeed = rotationSpeed / 2.0f;
    }

    //resets position, speed, and scale
    private void resetBallUlt() {
        gameObject.transform.localPosition /= 1.25f;
        rotationSpeed = rotationSpeed / 2.5f;
        gameObject.transform.localScale += new Vector3(-1.25f, -1.25f, -1f);
    }

}
