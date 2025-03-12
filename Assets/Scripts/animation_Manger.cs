using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_Manger : MonoBehaviour
{
    public Animator Animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Animator.SetBool("Trigger", true);
            Debug.Log("Started Animation");
        }
    }

    public void Turret_turning_animation()
    {
        Animator.SetTrigger("Trigger_Turret_Turning");
    }

    public void Turret_Rising_barrel()
    {
        Animator.SetTrigger("Trigger_Turret_Rising_Barrel");
    }
}
