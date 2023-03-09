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
    public GeneralPlayerStats generalStuff;

    void Awake()
    {
        solStuff = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
        generalStuff = GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerStats>();
    }

    public void buyItem(string itemToActivate)
    {
        switch (pointsToUse)
        {
            case "superPoints":
                if (generalStuff.getSuperPoints() >= pointsToBuy)
                {
                    GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerStats>().superPoints -= pointsToBuy;
                    //this will be the item in question player buys
                    itemToPurchase.SetActive(false);
                    nextItemToPurchase.SetActive(true);
                } else
                {
                    //display text showing how many points needed to get item
                }
                break;
            case "solProPoints":
                if (generalStuff.getSolProPoints() >= pointsToBuy)
                {
                    GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerStats>().solProPoints -= pointsToBuy;
                    solStuff.solBuyItem(itemToActivate);
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
