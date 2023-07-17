using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowDescriptionOnMouseOver : MonoBehaviour
{
    public Image descriptionOfAbility;
    public TMP_Text textForDescription;
    private Color imageColor;
    private Color textColor;
    private float changedAlpha = 0.0f;
    private float mainAlpha = 1.0f;


    // Update is called once per frame
    void Awake()
    {
        imageColor = descriptionOfAbility.color;
        textColor = textForDescription.color;

        imageColor.a = changedAlpha;
        descriptionOfAbility.color = imageColor;
        textColor.a = changedAlpha;
        textForDescription.color = textColor;
    }

    public void OnMouseEnter()
    {
        imageColor.a = mainAlpha;
        descriptionOfAbility.color = imageColor;
        textColor.a = mainAlpha;
        textForDescription.color = textColor;
        Debug.Log("hi");
    }


    public void OnMouseOver()
    {
        imageColor.a = mainAlpha;
        descriptionOfAbility.color = imageColor;
        textColor.a = mainAlpha;
        textForDescription.color = textColor;
        Debug.Log("hi");
    }

    public void OnMouseExit()
    {
        imageColor.a = changedAlpha;
        descriptionOfAbility.color = imageColor;
        textColor.a = changedAlpha;
        textForDescription.color = textColor;
        Debug.Log("hi");
    }
}
