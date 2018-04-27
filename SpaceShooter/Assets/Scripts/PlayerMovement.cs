using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //System Serializable allows you to change varabiles in the editior.
    [System.Serializable]
    public class Boundry
    {
        float xMin;
        float xMax;
        float yMin;
        float yMax;
    }

    float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(xAxis, yAxis) * Time.deltaTime * speed);
    }
}
