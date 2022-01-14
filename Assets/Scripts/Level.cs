using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    // Function to load the Start Menu scene
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    // Function to load the Game scene
    public void LoadGameScene()
    {
        FindObjectOfType<GameSession>().ResetGame();
        SceneManager.LoadScene("Game");
    }

    // Function to load the Game Over scene through a coroutine
    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    // Coroutine for loading Game Over scene
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver");
    }

    // Function to Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
