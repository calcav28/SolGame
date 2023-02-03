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
    // Start is called before the first frame update
    void Start()
    {
        imageColor = mainImage.color;
    }

    // Update is called once per frame
    void Update()
    {
        abilityUsed = GameObject.Find("Circle1").GetComponent<RotateAroundPoint>().usedAbility;
        if ((Input.GetKeyDown(firstKey) || Input.GetKeyDown(secondKey)) && abilityUsed)
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
