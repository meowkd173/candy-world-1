using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    public int maxHealth = 100;
    private int currentHealth;
    [SerializeField] HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Player HP: " + currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player took " + damage + " damage. HP left: " + currentHealth);
        healthBar.TakeDamage(damage);
        healthBar.UpdateHealthBar();

        sprite.color = Color.red;
        Invoke("MakeWhite", 0.5f);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void MakeWhite()
    {
        sprite.color = Color.white;
    }
    private void Die()
    {
        Debug.Log("Player died!");
        // Здесь можно добавить анимацию смерти, отключить управление, перезапустить уровень и т.д.
        gameObject.SetActive(false);
        SceneManager.LoadScene("Game");
    }
    public void HealToMax()
    {
        currentHealth = maxHealth;
        
        Debug.Log("Здоровье восстановлено!");
    }

}