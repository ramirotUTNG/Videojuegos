﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime*20*speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right  * rotationSpeed*40*verticalInput);
        transform.Rotate(Vector3.up  * rotationSpeed*30*horizontalInput);
        

    }
}
