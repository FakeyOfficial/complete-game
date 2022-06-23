using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTree : MonoBehaviour
{
    public BoxCollider2D col;
    [Tooltip("0 - on ground, 1 - should crouch")]
    public int treeState;
    public Animator animator;

    Vector2 treeOnGround = new Vector2(.3f, -.3f);
    Vector2 treeCrouch = new Vector2(.3f, -.06f);

    void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetTrigger("Fall");
    }
}
