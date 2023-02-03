using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataToSave : MonoBehaviour
{

    //Following data will be saved with PlayerPref

    //Settings Data (player preferences, volume, other graphical preferences, etc.)
    public int currentVolume; // [0, 100]

    public void setInt(string keyName, int value)
    {
        PlayerPrefs.SetInt("currentVolume", 50);
    }


    // Following data will be saved with JSON serialization

    // Player 

    // Player Achievements
    int highScore;

}
