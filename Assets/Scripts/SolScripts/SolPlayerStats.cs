using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SolPlayerStats : MonoBehaviour
{
    public bool wasdMovement;

    public int solProPoints;

    public int solEasyHighScore;
    public int solEasyTime;
    public int solMedHighScore;
    public int solMedTime;
    public int solHardHighScore;
    public int solHardTime;
    public int solGamesPlayed;

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
            case "fAbilityActivate":
                solHasFAbility = true;
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
}
