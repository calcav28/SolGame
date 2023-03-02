using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSwap : MonoBehaviour
{
    public GameObject mainButton;
    public GameObject otherButton;

    public void changeMovement()
    {
        if (mainButton.activeSelf)
        {
            mainButton.SetActive(false);
            otherButton.SetActive(true);
        }
    }
}
