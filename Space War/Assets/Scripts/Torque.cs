using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    public Object obstacle;
    private Vector3 turn;
    public float turnForce = 5;

    void Start()
    {
        turn = new Vector3(Random.Range(-turnForce, turnForce), Random.Range(-turnForce, turnForce), Random.Range(-turnForce, turnForce));         
    }
    void Update()
    {
        transform.Rotate(turn * turnForce * Time.deltaTime); 
    }

}
