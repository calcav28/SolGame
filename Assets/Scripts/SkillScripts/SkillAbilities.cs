using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAbilities : MonoBehaviour
{
    public float qSpeed;
    public float qCooldown;
    public float wSpeed;
    public float eSpeed;
    public float rSpeed;


    void Update() {

        //shoot skillshot
        if(Input.GetKeyDown(KeyCode.Q)) {
            useQ();
        }

        //movement speed boost
        if (Input.GetKeyDown(KeyCode.W)) {
            useW();
        }

        //dash ability
        if (Input.GetKeyDown(KeyCode.E)) {
            useE();
        }

        //ultimate ability
        if (Input.GetKeyDown(KeyCode.R)) {
            useR();
        }

    }


    void useQ() {

    }

    void useW() {

    }

    void useE() {

    }

    void useR() {

    }
}
