using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag_Control : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        anim.Play("Flag_movement");
    }
}
