using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillLevelTracker : MonoBehaviour
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


    //0 is shooting gallery, -1 is pvp or another mode, 1-10 is the respective level                        
    void setLevel(int currentLevel)
    {
        switch (currentLevel)
        {
            case 1: popsToWin = 5;
                break;
        }
    }
}
