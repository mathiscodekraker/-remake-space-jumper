using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private bounce bounce;
    private death death;
    public PlatformCreation pc;
    public BackgroundCreation bc;

    void Start()
    {
        bounce = GetComponent<bounce>();
        death = GetComponent<death>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            death.Death();
        }
        else if (other.gameObject.CompareTag("Platform"))
        {
            bounce.Bounce();
        }
        else if (other.gameObject.CompareTag("NextLevelLine"))
        {
            if (GetComponent<Collider2D>().isTrigger) return;
            pc.ReachedNextHeight();
        }
        else if (other.gameObject.CompareTag("Background"))
        {
            if (GetComponent<Collider2D>().isTrigger) return;
            bc.ReachedNextHeight();
        }
    }
}
