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
        
    }

    public void buyItem(string itemToActivate)
    {
        switch (pointsToUse)
        {
            case "superPoints":
            generalStuff = GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerStats>();
                if (generalStuff.getSuperPoints() >= pointsToBuy)
                {
                    GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerStats>().superPoints -= pointsToBuy;
                    //this will be the item in question player buys
                    itemToPurchase.SetActive(false);
                    nextItemToPurchase.SetActive(true);
                } else {
                    //display text showing how many points needed to get item
                }
                break;
            case "solProPoints":
                solStuff = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>();
                if (solStuff.getSolProPoints() >= pointsToBuy)
                {
                    GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solProPoints -= pointsToBuy;
                    solStuff.solBuyItem(itemToActivate);
                    itemToPurchase.SetActive(false);
                    nextItemToPurchase.SetActive(true);
                }
                else {
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
        //call save here
        GameObject.Find("GlobalScripts").GetComponent<SaveLoadSystem>().saveToJson();
    }

    public void givePoints() {
        GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().solProPoints += 100;
    }
}
