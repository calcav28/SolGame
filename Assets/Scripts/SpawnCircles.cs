using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I do not use this script at all, just look at how much I don't understand it...

public class SpawnCircles : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnCircles;
    public GameObject quad;

    void Start()
    {
        spawnObjects();
    }

    public void spawnObjects() {
        int randomItem = 0;
        GameObject toSpawn;
        float screenX, screenY;
        Vector2 pos;
        MeshCollider c = quad.GetComponent<MeshCollider>();
    
        for(int i = 0; i < numberToSpawn; i++) {
            randomItem = Random.Range(0, spawnCircles.Count);
            toSpawn = spawnCircles[randomItem];


            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);

        }

    }

}
