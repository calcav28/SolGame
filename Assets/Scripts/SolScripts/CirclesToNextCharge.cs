using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CirclesToNextCharge : MonoBehaviour
{
    public TMP_Text myText;
    public int circlesRemaining;

    void Update()
    {
        circlesRemaining = GameObject.Find("Character").GetComponent<Invulnerability>().circlesNeeded - 
        GameObject.Find("Character").GetComponent<Invulnerability>().ballInvCounter;
        myText.text = circlesRemaining.ToString();
    }
}
