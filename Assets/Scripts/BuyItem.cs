using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{

    public GameObject itemToPurchase;
    public GameObject nextItemToPurchase;
    public int pointsToBuy;
    public string pointsToUse;
    public SolPlayerStats solStuff;

    void Awake()
    {
        solStuff = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
    }

    public void buyItem(bool itemToActivate)
    {
        switch (pointsToUse)
        {
            case "superPoints":
                if (GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerData>().superPoints >= pointsToBuy)
                {
                    GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerData>().superPoints -= pointsToBuy;
                    itemToActivate = true; //this will be the item in question player buys
                    itemToPurchase.SetActive(false);
                    nextItemToPurchase.SetActive(true);
                } else
                {
                    //display text showing how many points needed to get item
                }
                break;
            case "solProPoints":
                if (GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerData>().solProPoints >= pointsToBuy)
                {
                    GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerData>().solProPoints -= pointsToBuy;
                    itemToActivate = true; //this will be the item in question player buys
                    itemToPurchase.SetActive(false);
                    nextItemToPurchase.SetActive(true);
                }
                else
                {
                    //display text showing how many points needed to get item
                }
                break;
            case "skillProPoints":
                //code here
                break;
            case "stealthProPoints":
                //code here
                break;
        }
    }
}
