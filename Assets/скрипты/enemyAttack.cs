using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public int damage = 20;                    // Урон, наносимый игроку
    public float attackCooldown = 2f;          // Перезарядка между атаками
    private float nextAttackTime = 0f;         // Время следующей атаки

    GameObject other;

    void Update()
    {
        if (other == null)
        {  
            return; 
        }

        if (Time.time >= nextAttackTime)
        {
            PlayerHealth player = other.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage(damage);
                nextAttackTime = Time.time + attackCooldown;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            other = collider.gameObject;
        }
    }
    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            other = null;
        }
    }
}
