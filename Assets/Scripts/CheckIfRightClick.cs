using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfRightClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if (GameObject.Find("Character").GetComponent<SolMovement>().wasdMovement) {
            GameObject.Find("PlaceToMove").SetActive(false);
        }
    }

}
