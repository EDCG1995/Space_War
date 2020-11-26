using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private float enemyZposition;
    private float playerZposition;
    private float speed = 3.5f;
    public GameObject weaponShot;
    private float shot = 0.5f;
    private float nextShot = 0;
    private PlayerController playerControllerScript;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyZposition = transform.position.z;
        playerZposition = GameObject.FindGameObjectWithTag("Player").transform.position.z;

        if (!playerControllerScript.gameOver) 
        {

            if (enemyZposition > playerZposition)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }

            else if (enemyZposition < playerZposition)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            //if players Z position is close to enemy Z position, enemy will shoot
            if (Mathf.Abs(playerZposition) - Mathf.Abs(enemyZposition) > -0.5 && Mathf.Abs(playerZposition) - Mathf.Abs(enemyZposition) < 0.5 && Time.time > nextShot)
            {
                nextShot = Time.time + shot;
                Instantiate(weaponShot, new Vector3(transform.position.x - 13, transform.position.y, transform.position.z), weaponShot.transform.rotation);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shot")) 
        {
            Destroy(gameObject);
        }
        
    }
}
