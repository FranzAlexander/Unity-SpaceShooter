using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy Movement
    private float enemySpeed = 4f;

    // Enemy Shooting
    private float shootCoolDownDone = 10f;
    private float shootCoolDown = 10f;
    public float damage = 0.2f;
    
    // Game Objects
    public GameObject enemy;
    public GameObject firePoint;
    public GameObject enemyLaserType;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3(0, enemySpeed * Time.deltaTime, 0);

        Vector3 position = transform.position;

        position -= transform.rotation * velocity;

        transform.position = position;

        if (shootCoolDown == shootCoolDownDone)
        {
            GameObject firedEnemyLaser = Instantiate(enemyLaserType, firePoint.transform.position, Quaternion.Euler(0f, 0f, 90f));
            EnemyLaser enemyLaser = firedEnemyLaser.GetComponent<EnemyLaser>();
            shootCoolDown = 0f;
        }
        else
        {
            shootCoolDown += Time.deltaTime;
        }
    }
}
