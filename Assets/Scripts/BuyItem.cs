using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{

    public GameObject itemToPurchase;
    public GameObject nextItemToPurchase;
    public int pointsToBuy;
    public string pointsToUse;

    void buyItem()
    {
        switch (pointsToUse)
        {
            case "superPoints":
                if (GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerData>().superPoints >= pointsToBuy)
                {
                    GameObject.Find("GlobalScripts").GetComponent<GeneralPlayerData>().superPoints -= pointsToBuy;
                    //set appropriate boolean to true
                    itemToPurchase.SetActive(false);
                    nextItemToPurchase.SetActive(true);
                } else
                {
                    //display text showing how many points needed to get item
                }
                break;
            case "solProPoints":
                //code here
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
