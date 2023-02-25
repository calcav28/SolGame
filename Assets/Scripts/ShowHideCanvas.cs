using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideCanvas : MonoBehaviour
{
    public GameObject theCanvas;
    public GameObject currentButton;
    public GameObject otherButton;

    public void changeCanvas()
    {
        if (theCanvas.activeSelf)
        {
            theCanvas.SetActive(false);
            currentButton.SetActive(false);
            otherButton.SetActive(true);
        } else {
            theCanvas.SetActive(true);
            currentButton.SetActive(false);
            otherButton.SetActive(true);
        }
    }

}
