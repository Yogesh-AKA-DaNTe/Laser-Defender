using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    // Variables for storing Score Text and Game Session
    Text scoreText;
    GameSession gameSession;

    void Start()
    {
        // Assigning Score Text and Game Session
        scoreText = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();
    }

    void Update()
    {
        // Updating score text
        scoreText.text = gameSession.GetScore().ToString();
    }
}
