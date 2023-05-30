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


    //get methods for points
    public int getSuperPoints()
    {
        return superPoints;
    }

}
