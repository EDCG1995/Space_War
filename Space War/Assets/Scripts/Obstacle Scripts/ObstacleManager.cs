﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] obstacles;
    private float zRange = 50;
    private float xRange = 50;
    private float startTime = 2;
    private float intervalTime = 3.0f;
    private PlayerController playerControllerScript;
 
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacles", startTime, intervalTime);
    }

    void Update()
    {
    }

    void SpawnObstacles() 
    {
        if (!playerControllerScript.gameOver)
        {
            int obstacleIndex = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[obstacleIndex], new Vector3(xRange, 5, Random.Range(-zRange, zRange)), obstacles[obstacleIndex].transform.rotation);
        }
        
    }
}
