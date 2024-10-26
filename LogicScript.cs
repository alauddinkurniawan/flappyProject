using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pauseScreen;
    public bool gameLoss = false;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    } 

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameLoss = true;
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }
    public void resumeGame()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
