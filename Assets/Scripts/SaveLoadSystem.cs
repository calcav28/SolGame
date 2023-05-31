using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    public SolPlayerStats solStats;
    public SkillPlayerStats skillStats;

    void Update()
    {
        solStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
        skillStats = GameObject.Find("GlobalScripts").GetComponent<SkillPlayerStats>();
    }


    public void saveToJson()
    {
        //get all class types and assign them to scripts in GlobalScripts
        SolPlayerStats jsonSolStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
        string json = JsonUtility.ToJson(jsonSolStats, true);
        File.WriteAllText(Application.dataPath + "/solStats.json", json);

        SkillPlayerStats jsonSkillStats = GameObject.Find("GlobalScripts").GetComponent<SkillPlayerStats>();
        json = JsonUtility.ToJson(jsonSkillStats, true);
        File.WriteAllText(Application.dataPath + "/skillStats.json", json);

    }

    public void loadFromJson()
    {
        //solScript Loading
        string json = File.ReadAllText(Application.dataPath + "/solStats.json");
        solStats = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
        JsonUtility.FromJsonOverwrite(json, solStats);
    }
}
