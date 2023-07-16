using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconInteraction : MonoBehaviour
{

    public Image mainImage;
    public Image barImage;
    public GameObject otherObject1;
    public GameObject otherObject2;
    public GameObject otherObject3;
    public KeyCode firstKey;
    public KeyCode secondKey;
    public bool abilityUsed;
    private Color imageColor;
    private float mainAlpha = 1.0f;
    private float changedAlpha = 0.5f;
    public float abilityCooldown;
    public string abilityToCheck;
    public bool canUseAbility;


    void Awake()
    {
        imageColor = mainImage.color;
        canUseAbility = GameObject.Find("GlobalScripts").GetComponent<SolPlayerStats>().getIfPurchased(abilityToCheck);
        switch (abilityToCheck)
        {
            case "eAbility":
                abilityCooldown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballSizeCooldown;
                break;
            case "rAbility":
                abilityCooldown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballSpeedCooldown;
                break;
            case "fAbility":
                abilityCooldown = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().ballUltCooldown;
                break;
        }
    }

    void Update()
    {
        if (!canUseAbility)
        {
            mainImage.enabled = false;
            barImage.enabled = false;
            otherObject1.SetActive(false);
            otherObject2.SetActive(false);
            otherObject3.SetActive(false);
        }
        
        
        abilityUsed = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().usedAbility;
        if ((Input.GetKeyDown(firstKey) || Input.GetKeyDown(secondKey)) && abilityUsed && canUseAbility)
        {
            barImage.GetComponent<AbilityDurationBar>().cooldownTimer = 5.0f;
            imageColor.a = changedAlpha;
            mainImage.color = imageColor;
            Invoke("resetAlpha", abilityCooldown);
        }
    }

    public void resetAlpha()
    {
        imageColor.a = mainAlpha;
        mainImage.color = imageColor;
    }
}
