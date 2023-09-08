using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Health_Collider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Enemy_Test"))
        {
            HealthBar.health -= 10f;
        }
    }
}
