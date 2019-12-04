using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [HideInInspector]
    protected Joystick joystick;

    public float horizontalspeed = 3f;
    public float verticalspeed = 3f;
    public Animator animator;

    int left = 1;
    int right = 2;
    int up = 3;
    int down = 4;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    void Update()
    {
        var rigidbody2d = GetComponent<Rigidbody2D>();

        rigidbody2d.velocity = new Vector2(joystick.Horizontal * horizontalspeed,
                                           joystick.Vertical * verticalspeed);

        float moveX = joystick.Horizontal;
        float moveY = joystick.Vertical;

        if (Mathf.Abs(moveX) > Mathf.Abs(moveY)) //Compare the magnitude of X & Y, larger = priority movement
        {
            horizontalspeed = 5f;
            verticalspeed = 0f;
            animator.SetBool("x_move", true);
            animator.SetBool("y_move", false);

            //For moving animation along X
            if (moveX < 0) //if X negative
            {
                animator.SetFloat("x", -1);
                animator.SetInteger("left", left);
                animator.SetInteger("stop", -1);
                //animator.SetTrigger("move");
            }
            else
            {
                animator.SetFloat("x", 1);
                animator.SetInteger("right", right);
                animator.SetInteger("stop", 1);
               // animator.SetTrigger("move");
            }
        }
        else if (Mathf.Abs(moveX) < Mathf.Abs(moveY))
        {
            verticalspeed = 5f;
            horizontalspeed = 0f;

            animator.SetBool("y_move", true);
            animator.SetBool("x_move", false);

            if (moveY < 0) //if Y negative

            {
                animator.SetFloat("y", -1);
                animator.SetInteger("down", down);
                animator.SetInteger("stop", -1);
                //animator.SetTrigger("move");
            }
            else
            {
                animator.SetFloat("y", 1);
                animator.SetInteger("up", up);
                animator.SetInteger("stop", 1);
                //animator.SetTrigger("move");
            }
        }
        if (moveX == 0 && moveY == 0)
        {
            animator.SetTrigger("move");
            animator.SetFloat("x", 0);
            animator.SetFloat("y", 0);
        }
    }
}

