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
    public bool hasBeenPurchased;
    public string itemToCheck;
    public GameObject itemDescription;

    void Start()
    {
        //hasBeenPurchased = solStuff.getIfPurchased(itemToCheck);
        
        if (hasBeenPurchased)
        {
            itemToPurchase.SetActive(false);
            nextItemToPurchase.SetActive(true);
        }

    }

    void Awake()
    {
        //hasBeenPurchased = solStuff.getIfPurchased(itemToCheck);

        if (hasBeenPurchased)
        {
            itemToPurchase.SetActive(false);
            nextItemToPurchase.SetActive(true);
        }

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
                    itemToPurchase.GetComponent<ShowDescriptionOnMouseOver>().OnMouseExit(); //not working, fix later
                    GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
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
