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

    void Start()
    {
        cooldownImage.fillAmount = cooldownTimer;
    }

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
