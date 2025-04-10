using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int Playerscore;
    public Text Textscore;
    public GameObject gameOverScreen;

    [ContextMenu("addScore")]
    public void addScore(int scoreToAdd)
    {
        Playerscore += scoreToAdd;
        Textscore.text = Playerscore.ToString();

    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {

        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Game Over ✅ Time stopped: " + Time.timeScale);
    }
    
    public void MainMenu(){

        SceneManager.LoadScene("Home Page");
    }


}
