using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    [Header("HealthBar")]
    [SerializeField] Slider healthBar;
    [SerializeField]Health health;

    [Header("ScoreBar")]
    [SerializeField] TextMeshProUGUI score;
    ScoreKeeper scoreKeeper; 

    void Awake() 
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();    
    }

    void Start()
    {
        healthBar.maxValue = health.GetHealth();
    }

    void Update()
    {
        healthBar.value = health.GetHealth();
        score.text = scoreKeeper.GetScore().ToString("000000000");
    }
}
