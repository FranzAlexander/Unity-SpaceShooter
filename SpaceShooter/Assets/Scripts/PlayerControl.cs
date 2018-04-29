using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    // Player movement
    private float speed = 10f;
    private float startPosition = -8f;

    // Player shooting
    private float shotEnergyAmount = 1f;
    private float energyReplenish = 0.2f;
    public float eneryAmount = 1f;
    private float weaponOverheatCoolDown = 0.4f;
    private bool weaponOverheat = false;

    // Game objects
    public GameObject laserBeam;
    public GameObject leftTurret;
    public GameObject rightTurret;

    // Player UI Elements
    public Image energyBar;

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

        transform.Translate(new Vector2(xAxis, yAxis) * Time.deltaTime * speed);

        // Calling every frame if the spacebar is press.
        //if (Input.GetButton("Jump"))
        if (Input.GetKeyDown("space"))
        {
            if (shotEnergyAmount <= eneryAmount)
            {
                eneryAmount -= shotEnergyAmount;
                Instantiate(laserBeam, leftTurret.transform.position, transform.rotation);
                Instantiate(laserBeam, rightTurret.transform.position, transform.rotation);
                shootSound.Play();
            }
        }

        eneryAmount += energyReplenish * Time.deltaTime;

        eneryAmount = Mathf.Clamp(eneryAmount, 0f, 1f);
        energyBar.fillAmount = eneryAmount;
    }
}
