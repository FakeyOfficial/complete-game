using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearDetectionZone : MonoBehaviour
{
    public Animator animator;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            animator.SetTrigger("Hit");
        }
    }
}
