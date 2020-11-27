using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 15;
    private PlayerController playerControllerScript;
    private float leftBound = -200;
    private float startPos = 395;
    private float repeatPos = -398.6f;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        if (transform.position.x < repeatPos)
        {
            transform.position = new Vector3(startPos, -5, 0);
        }
    }
}
