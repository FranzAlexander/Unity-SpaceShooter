using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    // Laser Movement
    public float laserSpeed;

    // Enemy Effects
    private bool exploded = false;
    private Vector3 lastPosition;
    public GameObject enemyExplosion;
    private SpriteRenderer spriteRenderer;

    // Sprite
    public Sprite[] explosion;

    // Player Object
    PlayerControl player = new PlayerControl();

    // Update is called once per frame
    void Update()
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        // If this collider on this object hits the collider on the game object with the "Enemy" tag.
        if (collision.gameObject.tag == "Enemy")
        {
            // Getting the last position of the object for the effect.
            lastPosition = transform.position;
            // Destory the game objects that came into contact.
            Destroy(collision.gameObject);
            Destroy(gameObject);

            exploded = true;

            EnemyDestoryedEffect(exploded);
        }
    }

    // Method that is going to just be for visual effet.
    void EnemyDestoryedEffect(bool enemyDestroyed)
    {
        // Getting a random number between the range of 0 and 8.
        int randomSpriteNumber = Random.Range(0, 8);

        spriteRenderer = enemyExplosion.GetComponent<SpriteRenderer>();

        // The enemy has been destroyed.
        if (enemyDestroyed)
        {
            // Assign the random sprite from the array to the game object.
            spriteRenderer.sprite = explosion[randomSpriteNumber];

            // Create the game object at the last position of the enemy.
            Instantiate(enemyExplosion, lastPosition, transform.rotation);
        }
    }
}
