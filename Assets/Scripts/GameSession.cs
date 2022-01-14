using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    // Variable for storing score
    int score = 0;

    private void Awake()
    {
        // Singleton Pattern for GameSession
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Function to get current score
    public int GetScore()
    {
        return score;
    }

    // Function to add score
    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    // Function to reset the game
    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
