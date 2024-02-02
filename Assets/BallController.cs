using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb; //Declare a RigidBody2d variable
        rb = GetComponent<Rigidbody2D>(); //Get a reference to the RigidBody

        //Set velocity
        rb.velocity = new Vector2(Random.Range(-200, 200), Random.Range(-200, 200));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
