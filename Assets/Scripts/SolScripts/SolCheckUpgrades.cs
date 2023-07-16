using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolCheckUpgrades : MonoBehaviour
{
    public string firstUpgradeCheck;
    public string secondUpgradeCheck;
    public bool boughtFirstUpgrade;
    public bool boughtSecondUpgrade;
    public GameObject firstUpgrade;
    public GameObject secondUpgrade;
    // Update is called once per frame
    void Update()
    {
        boughtFirstUpgrade = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().getIfPurchased(firstUpgradeCheck);
        boughtSecondUpgrade = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().getIfPurchased(secondUpgradeCheck);
        checkFirstUpgrade();
        checkSecondUpgrade();
    }


    void checkFirstUpgrade()
    {
        if (boughtFirstUpgrade)
        {
            firstUpgrade.SetActive(false);
            secondUpgrade.SetActive(true);
        }
    }

    void checkSecondUpgrade()
    {
        if (boughtSecondUpgrade)
        {
            secondUpgrade.SetActive(false);
        }
    }
}
