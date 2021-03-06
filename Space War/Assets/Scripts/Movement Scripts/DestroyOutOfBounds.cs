﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float boundMinusX =-200;
    private float boundPlusX = 55;
    private float boundY;
    private float boundZ = 70;
    private int obstacleCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < boundMinusX || transform.position.x > boundPlusX) 
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -boundZ || transform.position.z > boundZ) 
        {
            Destroy(gameObject);
        }
    }
}
