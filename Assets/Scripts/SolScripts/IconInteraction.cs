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
    public Color imageColor;
    public float mainAlpha;
    public float changedAlpha;
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
            barImage.GetComponent<AbilityDurationBar>().setCooldown();
            imageColor.a = changedAlpha;
            mainImage.color = imageColor;
            Invoke("resetAlpha", 10.0f);
        }
    }

    public void resetAlpha()
    {
        imageColor.a = mainAlpha;
        mainImage.color = imageColor;
    }
}
