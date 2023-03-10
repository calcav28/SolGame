using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject pivotObject;
    public float ballSizeTimer = 10;
    public float ballSpeedTimer = 10;
    public float ballUltTimer = 15;
    public float ballSizeCooldown = 10;
    public float ballSpeedCooldown = 10;
    public float ballUltCooldown = 15;
    public bool usedAbility = false;
    public bool hasBallRotation;
    public bool hasBallSize;
    public bool hasBallSpeed;
    public bool hasBallUlt;
    
    void Awake()
    {
        //handle getting keybinds for player plus booleans for abilities


        //abilities:
        hasBallRotation = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasQAbility;
        hasBallSize = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasEAbility;
        hasBallSpeed = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasRAbility;
        hasBallUlt = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solHasFAbility;

        //ability upgrades:

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
        if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Q)) && hasBallRotation) {
            rotationSpeed = rotationSpeed * -1.0f;
        }

        //makes balls bigger, 2/E
        if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.E)) && hasBallSize
            && ballSizeTimer >= 10.0f) {
            usedAbility = true;
            ballSizeTimer = 0;
            gameObject.transform.localScale += new Vector3(1.25f, 1.25f, 1f);
            Invoke("resetUsedAbility", 0.00001f);
            Invoke("resetBallSize", 5.0f);
        }

        //makes balls rotate faster, 3/R
        if ((Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.R)) && hasBallSpeed
            && ballSpeedTimer >= 10.0f) {
            usedAbility = true;
            ballSpeedTimer = 0;
            rotationSpeed = rotationSpeed * 2.0f;
            Invoke("resetUsedAbility", 0.00001f);
            Invoke("resetBallSpeed", 5.0f);
        }
        
        //ultimate ability, 4/F,
        if ((Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.F)) && hasBallUlt
            && ballUltTimer >= 15.0f) {
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
