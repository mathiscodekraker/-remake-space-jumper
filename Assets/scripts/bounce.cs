using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public float bounceForce = 15f;
    private Rigidbody2D rb;

    //functions 
    public void Bounce()
    {
        Debug.Log("Bounce");
        rb.velocity = new Vector2(rb.velocity.x, bounceForce);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
