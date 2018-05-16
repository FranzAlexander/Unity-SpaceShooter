using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    private float countDown = 3f;
    private float countDownRate = 1f;

    // Update is called once per frame
    void Update()
    {
        // Making the object get bigger to make the effect look better.
        transform.localScale = new Vector3(transform.localScale.x + (2f * Time.deltaTime), transform.localScale.y + (2f * Time.deltaTime), 0f);

        countDown -= countDownRate * Time.deltaTime;

        if (countDown <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
