using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 movement;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Получаем направление движения
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       

        animator.SetFloat("MoveX", movement.x);
        animator.SetFloat("MoveY", movement.y);
        sprite.flipX = movement.x > 0;
        
    }

    void FixedUpdate()
    {
        // Двигаем персонажа
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

}
