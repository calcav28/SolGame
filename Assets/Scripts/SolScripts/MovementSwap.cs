using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSwap : MonoBehaviour
{
    public GameObject mainButton;
    public GameObject otherButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void changeMovement()
    {
        if (mainButton.activeSelf)
        {
            mainButton.SetActive(false);
            otherButton.SetActive(true);
        }
    }
}
