using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy Spawn
    private float spawnRate = 10f;
    private float spawnEnemy = 0f;

    // Game objects
    public GameObject enemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(8f, Random.Range(-4.5f, 4.5f), 1f);

        spawnEnemy++;
        if (spawnEnemy == spawnRate)
        {
            Instantiate(enemy, position, transform.rotation);
            spawnEnemy = 0f;
        }
    }
}
