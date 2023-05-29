using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public void exitGame() {
        GameObject.Find("GlobalScripts").GetComponent<SaveLoadSystem>().saveToJson();
        Application.Quit();
        Debug.Log("Game has Quit!");
    }
}
