using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolGameStats : MonoBehaviour
{
    public string gameDifficulty;
    public GameObject spawnerOne;
    public GameObject spawnerTwo;
    public GameObject spawnerThree;
    public GameObject spawnerFour;
    public GameObject spawnerFive;
    public float enemyCircleSpeed;
    public float enemyCircleSize;


    // Start is called before the first frame update
    void Start()
    {
        spawnerOne = GameObject.Find("Spawner1");
        spawnerTwo = GameObject.Find("Spawner2");
        spawnerThree = GameObject.Find("Spawner3");
        spawnerFour = GameObject.Find("Spawner4");
        spawnerFive = GameObject.Find("Spawner5");

        switch(gameDifficulty)
        {
            case "easy":
                spawnerFive.SetActive(false);
                spawnerOne.GetComponent<RandomSpawner>().delay = 2;
                spawnerOne.GetComponent<RandomSpawner>().repeat = 5;
                spawnerTwo.GetComponent<RandomSpawner>().delay = 10;
                spawnerTwo.GetComponent<RandomSpawner>().repeat = 5;
                spawnerThree.GetComponent<RandomSpawner>().delay = 20;
                spawnerThree.GetComponent<RandomSpawner>().repeat = 5;
                spawnerFour.GetComponent<RandomSpawner>().delay = 30;
                spawnerFour.GetComponent<RandomSpawner>().repeat = 5;
                enemyCircleSpeed = 1.5f;
                enemyCircleSize = 1.0f;
                break;
            case "med":
                spawnerFive.SetActive(false);
                break;
            case "hard":
                spawnerFive.SetActive(true);
                break;
        }
    }

}
