using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public void exitGame() {
        Application.Quit();
        Debug.Log("Game has Quit!");
    }
}
