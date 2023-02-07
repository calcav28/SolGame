using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pauseGame();
        }
    }

    //unpauses game if in pause menu, pauses game if in game
    public void pauseGame()
    {
        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else if (!pauseMenu.activeSelf)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }

    }
}
