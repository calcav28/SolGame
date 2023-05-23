using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SolPlayerStats;
public class MovementSwap : MonoBehaviour
{
    public GameObject mainButton;
    public GameObject otherButton;
    public bool isKeyboard;
    public bool isMouse;

    void Awake() {
        if (GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().wasdMovement == true) {
            GameObject.Find("WASDMovement").SetActive(true);
            GameObject.Find("RightClickMovement").SetActive(false);
        } 
        if (GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().wasdMovement == false){
            GameObject.Find("WASDMovement").SetActive(false);
            GameObject.Find("RightClickMovement").SetActive(true);
        }
    }

    public void changeMovement()
    {
        if (mainButton.activeSelf)
        {
            mainButton.SetActive(false);
            otherButton.SetActive(true);
            setMovementType();
        }
    }

        public void setMovementType()
    {
        if(isKeyboard)
        {
            GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().wasdMovement = false;
        } 
        if (isMouse) 
        {
            GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().wasdMovement = true;
        }
    }
}
