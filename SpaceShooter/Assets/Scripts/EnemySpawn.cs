using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Enemy Spawn
    private float spawnRate = 100f;
    private float spawnEnemy = 0f;
    private float enemySpeed = 4f;

    // Game Objects
    public GameObject enemy;

    // Use this for initialization
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
            Instantiate(enemy, spawnPosition, transform.rotation);
            spawnEnemy = 0f;
        }

    }
}
