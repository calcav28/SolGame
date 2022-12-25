using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject circle;
    public float radius = 1.0f;
    public float delay;
    public float repeat;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObjectAtRandom", delay, repeat);
    }


    void spawnObjectAtRandom() {
        Vector3 randomPosit = new Vector3(transform.position.x + Random.Range(-3.0f, 3.0f), transform.position.y + Random.Range(-1.0f, 1.0f), 0);

        Instantiate(circle, randomPosit, Quaternion.identity);
    }
}
