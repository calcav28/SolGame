using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLoadSaves : MonoBehaviour
{
    void Awake()
    {
        GameObject.Find("GlobalScripts").GetComponent<SaveLoadSystem>().loadFromJson();
    }
}
