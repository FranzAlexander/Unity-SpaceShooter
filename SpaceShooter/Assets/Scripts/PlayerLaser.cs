using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{

    public float laserSpeed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * 0.2f);
        // transform.Translate(transform.position.normalized * laserSpeed, Space.World);
    }
}
