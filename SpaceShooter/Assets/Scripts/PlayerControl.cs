using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    float speed = 10f;

    public GameObject laserPrefab;
    public GameObject leftTurret;
    public GameObject rightTurret;


    // Update is called once per frame
    void Update()
    {
        // Horizontal and Vertical are both set in the input settings under the edit tab.
        // Horizontal is the Up/Down or W/S Keys.
        float xAxis = Input.GetAxis("Horizontal");
        // Vertical is the Left/Right or A/D Keys.
        float yAxis = Input.GetAxis("Vertical");


        transform.Translate(new Vector2(xAxis, yAxis) * Time.deltaTime * speed);

        // Calling every frame if the spacebar is press.
        if (Input.GetKeyDown("space"))
        {
            GameObject.Instantiate(laserPrefab, leftTurret.transform.position, Quaternion.identity);
            GameObject.Instantiate(laserPrefab, rightTurret.transform.position, Quaternion.identity);
        }

    }

}
