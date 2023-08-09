using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SolGameStats : MonoBehaviour
{
    public string gameDifficulty;
    public GameObject spawnerOne;
    public GameObject spawnerTwo;
    public GameObject spawnerThree;
    public GameObject spawnerFour;
    public GameObject spawnerFive;
    public float enemyRepeat;
    public float enemyCircleSpeed;
    public float enemyCircleSize;
    public int amountToAdd;

    public void setDifficulty()
    {
        spawnerOne = GameObject.Find("Spawner1");
        spawnerTwo = GameObject.Find("Spawner2");
        spawnerThree = GameObject.Find("Spawner3");
        spawnerFour = GameObject.Find("Spawner4");
        spawnerFive = GameObject.Find("Spawner5");


        switch (gameDifficulty)
        {
            case "easy":
                enemyRepeat = 7.0f;
                spawnerFive.SetActive(false);
                spawnerOne.GetComponent<RandomSpawner>().delay = 2;
                spawnerTwo.GetComponent<RandomSpawner>().delay = 10;
                spawnerThree.GetComponent<RandomSpawner>().delay = 20;
                spawnerFour.GetComponent<RandomSpawner>().delay = 30;
                spawnerOne.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerTwo.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerThree.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerFour.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                enemyCircleSpeed = 2.0f;
                enemyCircleSize = 1.0f;
                amountToAdd = 3;
                break;
            case "medium":
                enemyRepeat = 5.0f;
                spawnerFive.SetActive(false);
                spawnerOne.GetComponent<RandomSpawner>().delay = 1;
                spawnerTwo.GetComponent<RandomSpawner>().delay = 6;
                spawnerThree.GetComponent<RandomSpawner>().delay = 12;
                spawnerFour.GetComponent<RandomSpawner>().delay = 18;
                spawnerOne.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerTwo.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerThree.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerFour.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                enemyCircleSpeed = 2.5f;
                enemyCircleSize = 0.9f;
                amountToAdd = 4;
                break;
            case "hard":
                enemyRepeat = 3.5f;
                spawnerFive.SetActive(true);
                spawnerOne.GetComponent<RandomSpawner>().delay = 1;
                spawnerTwo.GetComponent<RandomSpawner>().delay = 6;
                spawnerThree.GetComponent<RandomSpawner>().delay = 12;
                spawnerFour.GetComponent<RandomSpawner>().delay = 18;
                spawnerFive.GetComponent<RandomSpawner>().delay = 24;
                spawnerOne.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerTwo.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerThree.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerFour.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                spawnerFive.GetComponent<RandomSpawner>().repeat = enemyRepeat;
                enemyCircleSpeed = 3.5f;
                enemyCircleSize = 0.8f;
                amountToAdd = 5;
                break;
        }
    }

}
