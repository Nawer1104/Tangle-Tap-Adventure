using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private Animator anim;

    public bool isTriggerd;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        isTriggerd = false;
    }

    public void TriggerAnim(string type)
    {
        if (isTriggerd) return;

        anim.SetTrigger(type);

        isTriggerd = true;
    }
}
