using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image Health_Bar;
    float maxHealth = 100f;
    public static float health;
    void Start()
    {
        Health_Bar = GetComponent<Image>();
        health = maxHealth;
    }

    
    void Update()
    {
        Health_Bar.fillAmount = health / maxHealth;
    }
}
