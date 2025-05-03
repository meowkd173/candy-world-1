using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("A");
        // Проверяем, игрок ли это
        if (other.CompareTag("Player"))
        {
            // Получаем компонент здоровья у игрока
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            print(playerHealth);
            if (playerHealth != null)
            {
                playerHealth.HealToMax(); // Восстанавливаем здоровье
                Destroy(gameObject);      // Удаляем монетку с карты
            }
        }
    }
   
}
