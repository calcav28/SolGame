using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour
{

    public int popsToWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setLevel(int currentLevel)
    {
        switch (currentLevel)
        {
            case 1: popsToWin = 5;
                break;
        }
    }
}
