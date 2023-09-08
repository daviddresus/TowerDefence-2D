using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Enemy : MonoBehaviour
{
    Image healthBar;
    public static float health;
    void Start()
    {
        health = 1;
        healthBar = GetComponent<Image>();
    }
    void Update()
    {
        if(health <= 0.1)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Arrow_Prefab"))
        {
            health -= 0.2f;
        }
    }
}
