using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SolPlayerStats : MonoBehaviour
{



    //keybinds and preferences
    public bool wasdMovement; //can be turned into int for more than 2 movement systems
    //need keybinds for q, e, r, f, and spacebar abilities

    //currency for abilties
    public int solProPoints;

    //high score stats for player based on difficulty
    public int solEasyHighScore;
    public int solEasyTime;
    public int solMedHighScore;
    public int solMedTime;
    public int solHardHighScore;
    public int solHardTime;
    public int solGamesPlayed;


    //all upgrades for player
    public bool solHasQAbility;
    public bool solHasQUpgrade;

    public bool solHasEAbility;
    public bool solHasEUpgrade;
    
    public bool solHasRAbility;
    public bool solHasRUpgrade;

    public bool solHasFAbility;
    public bool solHasFUpgrade;

    public bool solHasSpacebarAbility;
    public bool solHasSpacebarUpgrade;

    void Start() {
        wasdMovement = true;
    }

    public void solBuyItem(string itemToActivate)
    {
        switch (itemToActivate)
        {
            case "qAbilityActivate":
                solHasQAbility = true;
                break;
            case "qUpgradeActivate":
                solHasQUpgrade = true;
                break;
            case "eAbilityActivate":
                solHasEAbility = true;
                break;
            case "eUpgradeActivate":
                solHasEUpgrade = true;
                break;
            case "rAbilityActivate":
                solHasRAbility = true;
                break;
            case "rUpgradeActivate":
                solHasRUpgrade = true;
                break;
            case "fAbilityActivate":
                solHasFAbility = true;
                break;
            case "fUpgradeActivate":
                solHasFUpgrade = true;
                break; 
            case "spacebarAbilityActivate":
                solHasSpacebarAbility = true;
                break;
        }
    }

    public int getSolProPoints()
    {
        return solProPoints;
    }

    public bool getIfPurchased(string itemToCheck)
    {
        switch (itemToCheck)
        {
            case "qAbility":
                return solHasQAbility;
                //break;
            case "qUpgrade":
                return solHasQUpgrade;
                //break;
            case "eAbility":
                return solHasEAbility;
                //break;
            case "eUpgrade":
                return solHasEUpgrade;
                //break;
            case "rAbility":
                return solHasRAbility;
                //break;
            case "rUpgrade":
                return solHasRUpgrade;
                //break;
            case "fAbility":
                return solHasFAbility;
                //break;
            case "fUpgrade":
                return solHasFUpgrade;
                //break;
            case "spacebarAbility":
                return solHasSpacebarAbility;
                //break;
            default: return false;
        }
    }
}
