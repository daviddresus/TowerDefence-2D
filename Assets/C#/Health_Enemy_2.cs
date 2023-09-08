using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Enemy_2 : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    
    void Update()
    {
        localScale.x = HealthBar_Enemy.health;
        transform.localScale = localScale;
    }
}
