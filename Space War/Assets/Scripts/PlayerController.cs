using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float zRange = 50;
    public float backRange = -170;
    public float forwardRange = -125;
    public float rotationSpeed = 5;
    public float speed = 20;
    public bool gameOver;
    public GameObject weaponShot;
    void Start()
    {
        
    }

  
    void Update()
    {
        RangeSetup();
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = -Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(weaponShot, new Vector3(transform.position.x + 13, transform.position.y, transform.position.z), weaponShot.transform.rotation);
        }

        
    }

    void RangeSetup() 
    {
        //Z axis Range
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //X axis Range
        if (transform.position.x < backRange)
        {
            transform.position = new Vector3(backRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > forwardRange)
        {
            transform.position = new Vector3(forwardRange, transform.position.y, transform.position.z);
        }
    }
}
