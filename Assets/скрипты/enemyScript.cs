using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform player;              // Ссылка на игрока
    public float followRange = 5f;        // Радиус, в котором враг начинает следить за игроком
    public float stopDistance = 1f;       // Расстояние, на котором враг останавливается
    public float moveSpeed = 2f;          // Скорость врага

    private void Start()
    {
        player = FindAnyObjectByType<walkPlayer>().gameObject.transform;
    }
    private void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= followRange && distanceToPlayer > stopDistance)
        {
            // Движение к игроку
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;
        }
    }
}
