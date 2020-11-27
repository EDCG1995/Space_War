using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreInterface : MonoBehaviour
{
    public Text scoreIndicator;
    public int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }

    void UpdateScore() 
    {
        scoreIndicator.text ="Score: " + score.ToString(); 
    }
}
