using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;              // Префаб врага
    public Transform[] spawnPoints;             // Точки спавна (3 точки)

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        if (enemyPrefab == null || spawnPoints.Length == 0)
        {
            Debug.LogWarning("Не назначены префаб или точки спавна!");
            return;
        }

        for (int i = 0; i < Mathf.Min(3, spawnPoints.Length); i++)
        {
            Instantiate(enemyPrefab, spawnPoints[i].position, Quaternion.identity);
        }
    }
}
