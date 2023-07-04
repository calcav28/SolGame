using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[System.Serializable]
public class GeneralPlayerStats : MonoBehaviour
{
    //currency earned from all games
    public int superPoints;
    public int gamesPlayed;


    //setting choices for player
    public bool isFullscreen;
    public int musicNoise; //from [0, 100]
    public int soundEffectsNoise; //from [0, 100]


    //get methods for points
    public int getSuperPoints()
    {
        return superPoints;
    }

}
