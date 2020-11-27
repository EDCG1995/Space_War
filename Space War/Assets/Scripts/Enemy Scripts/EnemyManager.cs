using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemies;
    private float zRange = 50;
    private float xRange = 23;
    private int waveToSpawn = 2;
    private int enemyIndex;
    private int enemiesOnField;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        enemiesOnField = GameObject.FindGameObjectsWithTag("Enemy").Length;
        
        if (enemiesOnField <= 1 && !playerControllerScript.gameOver) 
        {
            for (int i = 0; i < waveToSpawn; i++) 
            {
                SpawnEnemies();        
            }
            if (waveToSpawn < 5) 
            { 
            waveToSpawn ++;
            }
        }
        
   
    }

    void SpawnEnemies() 
    {
        float xRangeEnemy = xRange - Random.Range(0,5) * 20; 
        enemyIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[enemyIndex], new Vector3(xRangeEnemy, 25, Random.Range(-zRange, zRange)), enemies[enemyIndex].transform.rotation);
        
    }
}
