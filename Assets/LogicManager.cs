using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int Playerscore;
    public Text Textscore;
    public GameObject gameOverScreen;
    public AudioSource loseAudio;
    public AudioSource winAudio;  // حقل جديد


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
        if (loseAudio != null)
            loseAudio.Play();

        if (gameOverScreen != null)
            gameOverScreen.SetActive(true);

        Debug.Log("Game Over ✅ Time stopped.");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Home Page");
    }
}