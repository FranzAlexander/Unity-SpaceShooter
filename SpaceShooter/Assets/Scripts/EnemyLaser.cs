using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float laserSpeed;

    public float damage;

    private bool hitEnemy = false;

    // Game Objects
    PlayerControl player;
    Enemy enemy;

    // Use this for initialization
    void Start()
    {
        player = new PlayerControl();
        enemy = new Enemy();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyLaserMovement();

        damage = enemy.damage;
    }

    void EnemyLaserMovement()
    {
        // Setting position to objects current position.
        Vector3 position = transform.position;

        Vector3 velocity = new Vector3(0, Time.deltaTime * laserSpeed, 0);
        // Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * laserSpeed, 0); Keep this code for now as it has cool effect.

        // Setting the position to the position it is at plus the rotation of the object times the velocity.
        position += transform.rotation * velocity;

        // Setting the position of this object to the new position.
        transform.position = position;

        // When the goes past 20 positions from the original position that game object will destroy itself.
        if (transform.position.x > 20f)
        {
            // Destroys the game object.
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            float currentHealth = player.health - damage;
            player.PlayerHealth(currentHealth);
            Debug.Log(currentHealth);
            Destroy(gameObject);
            //Debug.Log(player.damageTaken);
            //Debug.Log(player.playerHit);
        }
    }
}
