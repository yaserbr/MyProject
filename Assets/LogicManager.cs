using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int Playerscore;
    public int coinScore;  // عداد العملات
    public Text Textscore;
    public Text coinScoreText;

    public Text finalScore;
    public Text finalCoins;

    public GameObject gameOverScreen;
    public AudioSource loseAudio;
    public AudioSource winAudio;  
    public GameObject silverCup;
    public GameObject goldCup;

    [ContextMenu("addScore")]
    public void addScore(int scoreToAdd)
    {
        Playerscore += scoreToAdd;
        Textscore.text = Playerscore.ToString();
    }
    public void AddCoinScore(int points)
    {
        coinScore += points;
        coinScoreText.text = coinScore.ToString();
        PlayerPrefs.SetInt("CoinsCollected", coinScore);
        PlayerPrefs.Save();
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
        finalScore.text = "" + Playerscore;
        finalCoins.text = "" + coinScore;
        Debug.Log("Game Over ✅ Time stopped.");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Home Page");
    }

    void Update()
    {
        if (coinScore >= 5)
        {
            silverCup.SetActive(false);
            goldCup.SetActive(true);
        }
        else if (coinScore >= 2)
        {
            silverCup.SetActive(true);
            goldCup.SetActive(false);
        }
        else
        {
            silverCup.SetActive(false);
            goldCup.SetActive(false);
        }
    }
    void OnApplicationQuit()
{
    PlayerPrefs.SetInt("CoinsCollected", 0);
    PlayerPrefs.Save();
}

}