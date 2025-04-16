using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 50;
    private int currentHealth;

    private Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"{gameObject.name} получил урон: {damage}. Осталось HP: {currentHealth}");

        if (animator != null)
        {
            animator.SetTrigger("Hit"); // Воспроизводим анимацию получения урона (если есть)
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log($"{gameObject.name} умер!");

        if (animator != null)
        {
            animator.SetTrigger("Die");
        }

        // Можно дать время анимации проиграться, если нужно:
        Destroy(gameObject, 0.5f); // Уничтожить объект через 0.5 секунды
    }
}
