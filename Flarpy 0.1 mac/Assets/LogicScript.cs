using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public Text highScore;
    public int highestScore;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    void Start()
    {
        highestScore = PlayerPrefs.GetInt("highest Score", 0);
        highScore.text = "Highest:" + highestScore.ToString();
    }

    public void restartGame()
    {
        PlayerPrefs.SetInt("highest Score", highestScore);
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void highestRecord()
    {
        if (playerScore > highestScore)
        {
            highestScore = playerScore;
            highScore.text = "Highest:" + highestScore.ToString();
        }
    }


    
}
