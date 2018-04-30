using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy Movement
    private float enemySpeed = 4f;

    // Game Objects
    public GameObject enemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3(0, enemySpeed * Time.deltaTime, 0);

        Vector3 position = transform.position;

        position += transform.rotation * velocity;

        transform.position = position;
    }
}
