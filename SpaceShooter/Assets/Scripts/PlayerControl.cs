using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    // Player Movement
    private float speed = 10f;
    private float startPosition = -8f;

    // Player Shooting
    private float shotEnergyAmount = 1f;
    private float energyReplenish = 0.4f;
    public float energyAmount = 1f;
    private float weaponOverheatCoolDown = 0.4f;
    private bool weaponOverheat = false;

    // Game Objects
    public GameObject laserBeam;
    public GameObject leftTurret;
    public GameObject rightTurret;

    // Player UI Elements
    public Image energyBar;

    // Player Audio
    AudioSource shootSound;

    void Start()
    {
        // Starting the player position at the left side of the area.
        transform.position = new Vector3(startPosition, 0);

        shootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal and Vertical are both set in the input settings under the edit tab.
        // Vertical is the Up/Down or W/S Keys.
        float xAxis = Input.GetAxis("Vertical");
        // Horizontal is the Left/Right or A/D Keys.
        float yAxis = Input.GetAxis("Horizontal");

        // Move the player object.
        transform.Translate(new Vector2(xAxis, yAxis) * Time.deltaTime * speed);

        // Calling every frame if the spacebar is press.
        // If (Input.GetButton("Jump"))
        if (Input.GetKeyDown("space"))
        {
            // Checking if the player has enough enery to be able to shoot.
            if (shotEnergyAmount <= energyAmount)
            {
                // Decreasing the energy amount by the shot amount.
                energyAmount -= shotEnergyAmount;

                // Create the two laser objects at the position and rotation given.
                Instantiate(laserBeam, leftTurret.transform.position, transform.rotation);
                Instantiate(laserBeam, rightTurret.transform.position, transform.rotation);

                // Play the sound effect.
                shootSound.Play();
            }
        }

        // Replenish the energy amount over time.
        energyAmount += energyReplenish * Time.deltaTime;

        // Clamping so that energyAmount will always be between 0f and 1f.
        energyAmount = Mathf.Clamp(energyAmount, 0f, 1f);
        // Animating the energy bar image.
        energyBar.fillAmount = energyAmount;
    }
}
