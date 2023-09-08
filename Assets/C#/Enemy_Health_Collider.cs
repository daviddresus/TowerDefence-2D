using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health_Collider : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        HealthBar_Enemy.health -= 0.2f;
        Destroy(this.gameObject);
    }
}
