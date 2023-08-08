using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolSetDifficulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject.Find("GlobalScripts").GetComponent<SolGameStats>().setDifficulty();
    }

}
