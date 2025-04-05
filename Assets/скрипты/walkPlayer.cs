using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    private Vector2 movement;
    private bool isMoving;



    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        isMoving = movement.x != 0 || movement.y != 0;

        UpdateAnimation();
    }

    void FixedUpdaye()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

    void UpdateAnimation()
    {
        if (isMoving)
        {
            animator.SetFloat("Speed", movement.sqrMagnitude);

            if (movement.x > 0)
            {
                animator.SetFloat("MoveX", 1);
                animator.SetFloat("MoveY", 0);
            }

            else if (movement.x < 0)
            {
                animator.SetFloat("MoveX", -1);
                animator.SetFloat("MoveY", 0);
            }

            else if (movement.y > 0)
            {
                animator.SetFloat("MoveX", 0);
                animator.SetFloat("MoveY", 1);
            }

            else if (movement.y < 0)
            {
                animator.SetFloat("MoveX", 0);
                animator.SetFloat("MoveY", -1);
            }
        }

        else
        {
            animator.SetFloat("Speed", 0);
        }
    }
}
