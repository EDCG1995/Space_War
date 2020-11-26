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
    public float speed = 30;
    private float shot = 0.5f;
    private float nextShot = 0;
    public bool gameOver = false;
    public GameObject weaponShot;
    public int HP = 20;

    void Start()
    {
       
    }

  
    void Update()
    {
        RangeSetup();

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = -Input.GetAxis("Vertical");

        //Game over when HP reaches 0, else: normal movement and actions.
        if (HP <= 0)
        {
            HP = 0;
            Debug.Log(HP);
            gameOver = true;
        }
        else 
        {
            transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
            transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);
            
            //Weapon shot and cooldown.
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextShot)
            {
                nextShot = Time.time + shot;
                Instantiate(weaponShot, new Vector3(transform.position.x + 13, transform.position.y, transform.position.z), weaponShot.transform.rotation);
            }
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shot2")) 
        {
            HP -= 4;
            Debug.Log(HP);

        }
        if (other.gameObject.CompareTag("Obstacle")) 
        {
            HP -= 16;
            Debug.Log(HP);
            
        }

        
    }
}
