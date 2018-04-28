using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public float laserSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        Vector3 velocity = new Vector3(0, Time.deltaTime * laserSpeed, 0);
        // Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime * laserSpeed, 0); Keep this code for now as it has cool effect.

        position += transform.rotation * velocity;

        transform.position = position;

        // When the goes past 20 positions from the original position that game object will destroy itself.
        if (transform.position.x > 20f)
        {
            Destroy(gameObject);
        }
    }
}
