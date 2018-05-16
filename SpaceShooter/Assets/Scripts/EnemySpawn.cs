using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Enemy Spawn
    private float spawnRate = 200f;
    private float spawnEnemy = 0f;
    private float enemySpeed = 4f;

    // Game Objects
    public GameObject enemy;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPosition = new Vector3(8f, Random.Range(-4.5f, 4.5f), 1f);

        spawnEnemy++;

        if (spawnEnemy == spawnRate)
        {
            Instantiate(enemy, spawnPosition, enemy.transform.rotation);
            spawnEnemy = 0f;
        }

    }
}
