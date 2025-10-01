using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private bounce bounce;

    void Start()
    {
        bounce = GetComponent<bounce>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            Debug.Log("Spikes");
        }
        else if (other.gameObject.CompareTag("Platform"))
        {
            Debug.Log("Platform");
            bounce.Bounce();
        }
    }
}
