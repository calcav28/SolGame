using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    public SolPlayerStats solStats;

    void Awake()
    {
        solStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
    }


    public void saveToJson()
    {
        //get all class types and assign them to scripts in GlobalScripts
        SolPlayerStats jsonSolStats = new SolPlayerStats();
        jsonSolStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
        string json = JsonUtility.ToJson(solStats, true);
        File.WriteAllText(Application.dataPath + "/solStats.json", json);
    }

    public void loadFromJson()
    {
        //solScript Loading
        string json = File.ReadAllText(Application.dataPath + "/solStats.json");
        SolPlayerStats jsonSolStats = JsonUtility.FromJson<SolPlayerStats>(json);

        //loading abilities
        solStats.solHasQAbility = jsonSolStats.solHasQAbility;
        solStats.solHasEAbility = jsonSolStats.solHasEAbility;
        solStats.solHasRAbility = jsonSolStats.solHasRAbility;
        solStats.solHasFAbility = jsonSolStats.solHasFAbility;

        //loading scores
        solStats.solEasyHighScore = jsonSolStats.solEasyHighScore;
        solStats.solEasyTime = jsonSolStats.solEasyTime;
        solStats.solMedHighScore = jsonSolStats.solMedHighScore;
        solStats.solMedTime = jsonSolStats.solMedTime;
        solStats.solHardHighScore = jsonSolStats.solHardHighScore;
        solStats.solHardTime = jsonSolStats.solHardTime;
    }
}
