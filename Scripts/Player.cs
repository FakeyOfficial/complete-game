using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    public int health = 3;
    
    bool jump;
    bool crouch = false;

    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("RestartScene");
        }

        Animations();
    }

    void FixedUpdate()
    {
        controller.Move(runSpeed * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    public void Jump()
    {
        jump = true;
    }

    public void Crouch(bool state)
    {
        crouch = state;
    }

    void Animations()
    {
        if (crouch)
        {
            animator.SetBool("isCrouching", true);
        }
        else
        {
            animator.SetBool("isCrouching", false);
        }

        if (jump)
        {
            animator.SetTrigger("Jump");
        }
    }
}
