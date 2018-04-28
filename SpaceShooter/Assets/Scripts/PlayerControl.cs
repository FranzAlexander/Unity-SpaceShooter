using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Player movement
    float speed = 10f;
    float startPosition = -8f;

    // Player shooting
    float weaponCoolDown = 1f;
    float weaponEnergy = 100f;

    // Game objects
    public GameObject laserBeam;
    public GameObject leftTurret;
    public GameObject rightTurret;

    void Start()
    {
        // Starting the player position at the left side of the area.
        transform.position = new Vector3(startPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal and Vertical are both set in the input settings under the edit tab.
        // Vertical is the Up/Down or W/S Keys.
        float xAxis = Input.GetAxis("Vertical");
        // Horizontal is the Left/Right or A/D Keys.
        float yAxis = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(xAxis, yAxis) * Time.deltaTime * speed);

        // Calling every frame if the spacebar is press.
        //if (Input.GetButton("Jump"))
        if(Input.GetKeyDown("space"))
        {
            Instantiate(laserBeam, leftTurret.transform.position, transform.rotation);
            Instantiate(laserBeam, rightTurret.transform.position, transform.rotation);
        }

    }

}
