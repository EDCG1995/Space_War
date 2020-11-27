using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HPInterface : MonoBehaviour
{

    public Text HPIndicator;
    private PlayerController playerControllerScript;
    private EnemyBehaviour EnemyBehaviourScript;
    private int hPToPercentage;
    public int score;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        UpdateHP();
    }

    private void UpdateHP()
    {
        hPToPercentage = playerControllerScript.HP * 100 / 20;
        HPIndicator.text = "HP: " + hPToPercentage +"%";
    }
}
