using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEnemyRandomSpawner : MonoBehaviour
{
    public GameObject circle;
    public float radius = 1.0f;
    public float delay;
    public float repeat;

    //allows first game from start of session to load proper repeat depending on difficulty
    void Awake()
    {
        repeat = GameObject.Find("GlobalScripts").GetComponent<SolGameStats>().enemyRepeat; // * 2.0f;
    }

    void Start()
    {
        InvokeRepeating("spawnObjectAtRandom", delay, repeat);
    }

    void spawnObjectAtRandom()
    {
        Vector3 randomPosit = new Vector3(transform.position.x + Random.Range(-8.0f, 8.0f), transform.position.y + Random.Range(-0.3f, 0.3f), 0);

        Instantiate(circle, randomPosit, Quaternion.identity);
    }
}
