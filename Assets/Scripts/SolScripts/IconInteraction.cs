using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconInteraction : MonoBehaviour
{

    public Image mainImage;
    public Image barImage;
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
    }

    void Update()
    {
        if (!canUseAbility)
        {
            mainImage.enabled = false;
            barImage.enabled = false;
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
