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
        //also ensure to hide descriptions (afer buying item, and leaving screen totally, descripion comes back even though
        //original upgrade isn't there (since its gone from this script)
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
