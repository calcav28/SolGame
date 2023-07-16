using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QImageSwapper : MonoBehaviour
{

    public GameObject mainImage;
    public GameObject otherImage;
    public GameObject number;
    public GameObject rotation;
    public KeyCode firstKey;
    public KeyCode secondKey;
    public bool canUseAbility;
    public string abilityToCheck;

    void Awake()
    {
        canUseAbility = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().getIfPurchased(abilityToCheck);
    }

    void Update()
    {

        if (!canUseAbility)
        {
            mainImage.SetActive(false);
            otherImage.SetActive(false);
            number.SetActive(false);
            rotation.SetActive(false);  
        }

        if ((Input.GetKeyDown(firstKey) || Input.GetKeyDown(secondKey)) && mainImage.activeSelf && canUseAbility)
        {
            mainImage.SetActive(false);
            otherImage.SetActive(true);
        }
    }
}
