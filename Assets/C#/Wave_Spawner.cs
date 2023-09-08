using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawner : MonoBehaviour
{
    public Transform enemy;

    void Start()
    {
        StartCoroutine(spawnRate());
    }

    void Update()
    {

    }

    IEnumerator spawnRate()
    {
        yield return new WaitForSeconds(5);
        Instantiate(enemy, transform.position, transform.rotation);
        StartCoroutine(spawnRate());
    }
}
