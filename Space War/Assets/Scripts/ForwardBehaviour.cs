using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBehaviour : MonoBehaviour
{
    private Rigidbody obstacleRB;
    private float obstacleSpeed;
    private float energySpeed = 100.0f;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

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
        else if (gameObject.CompareTag("Shot2"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -energySpeed/3);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
