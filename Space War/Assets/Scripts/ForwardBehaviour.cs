using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBehaviour : MonoBehaviour
{
    private Rigidbody obstacleRB;
    private float obstacleSpeed;
    private float energySpeed = 170.0f;
    void Start()
    {
        
        if (gameObject.CompareTag("Obstacle"))
        {
            obstacleSpeed = Random.Range(1000, 3000);
            obstacleRB = GetComponent<Rigidbody>();
            obstacleRB.AddForce(Vector3.left * obstacleSpeed, ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.CompareTag("Shot"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * energySpeed);
        }
        
    }
}
