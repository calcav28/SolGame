using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    public SolPlayerStats solStats;

    void Update()
    {
        solStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
    }


    public void saveToJson()
    {
        //get all class types and assign them to scripts in GlobalScripts
        SolPlayerStats jsonSolStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
        string json = JsonUtility.ToJson(jsonSolStats, true);
        File.WriteAllText(Application.dataPath + "/solStats.json", json);
    }

    public void loadFromJson()
    {
        //solScript Loading
        string json = File.ReadAllText(Application.dataPath + "/solStats.json");
        solStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
        JsonUtility.FromJsonOverwrite(json, solStats);

        /*
        //general sol stuff
        solStats.solProPoints = jsonSolStats.solProPoints;
        solStats.wasdMovement = jsonSolStats.wasdMovement;

        //loading abilities
        solStats.solHasQAbility = jsonSolStats.solHasQAbility;
        solStats.solHasEAbility = jsonSolStats.solHasEAbility;
        solStats.solHasRAbility = jsonSolStats.solHasRAbility;
        solStats.solHasFAbility = jsonSolStats.solHasFAbility;

        //loading upgrades
        solStats.solHasQUpgrade = jsonSolStats.solHasQUpgrade;
        solStats.solHasEUpgrade = jsonSolStats.solHasEUpgrade;
        solStats.solHasRUpgrade = jsonSolStats.solHasRUpgrade;
        solStats.solHasFUpgrade = jsonSolStats.solHasFUpgrade;

        //loading scores
        solStats.solEasyHighScore = jsonSolStats.solEasyHighScore;
        solStats.solEasyTime = jsonSolStats.solEasyTime;
        solStats.solMedHighScore = jsonSolStats.solMedHighScore;
        solStats.solMedTime = jsonSolStats.solMedTime;
        solStats.solHardHighScore = jsonSolStats.solHardHighScore;
        solStats.solHardTime = jsonSolStats.solHardTime;
        */
    }
}
