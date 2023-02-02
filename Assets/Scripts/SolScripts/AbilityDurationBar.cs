using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityDurationBar : MonoBehaviour
{
    public Image cooldownImage;
    public float cooldownTime = 5.0f;
    public float cooldownTimer = 0.0f;
    public float thisIsATest;
    // Start is called before the first frame update
    void Start()
    {
        cooldownImage.fillAmount = cooldownTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
            cooldownImage.fillAmount = cooldownTimer / cooldownTime;
        }
    }

    public void setCooldown()
    {
        cooldownTimer = 5.0f;
    }
}
