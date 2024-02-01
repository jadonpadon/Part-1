using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float speed = 5f;
    float steering;
    float accelerate;
    public float steerSpeed = 10f;
    public float maxSpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accelerate = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steerSpeed * Time.deltaTime);
        Vector2 force = transform.up * accelerate * speed * Time.deltaTime;
        if (rigidbody.velocity.magnitude < maxSpeed);
        {
            rigidbody.AddForce(force);
        }
    }

    
}
