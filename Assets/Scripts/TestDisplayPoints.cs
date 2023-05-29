using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestDisplayPoints : MonoBehaviour
{
    public TMP_Text textForPoints;
    public int currentPoints;

    // Update is called once per frame
    void Update()
    {
        currentPoints = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solProPoints;
        textForPoints.text = currentPoints.ToString();
    }
}
