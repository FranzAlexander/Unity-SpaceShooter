using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    float speed = 10f;
    bool shouldFire = false;

    public GameObject laserBeam;
    public GameObject leftTurret;
    public GameObject rightTurret;

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
        if (Input.GetButton("Jump"))
        {
          Instantiate(laserBeam, leftTurret.transform.position, transform.rotation);
          Instantiate(laserBeam, rightTurret.transform.position, transform.rotation);
        }

    }

}
