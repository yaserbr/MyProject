using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;



public class GameModeHandler : MonoBehaviour
{
    public GameObject missionUI;
    public TMP_Text missionTimerText; 
    public float missionTime = 10f;

    public GameObject victoryCanvas;

    public AudioSource clapAudio;

    private bool hasWon = false;

    void Start()
    {
        Debug.Log("✅ GameModeHandler Started");

        switch (GameModeManager.SelectedMode)
        {
            case GameModeManager.GameMode.Easy:
                SetEasyMode();
                break;
            case GameModeManager.GameMode.Hard:
                SetHardMode();
                break;
            case GameModeManager.GameMode.Mission:
                SetMissionMode();
                break;
        }
    }

    void Update()
    {
        
        if (GameModeManager.SelectedMode == GameModeManager.GameMode.Mission)
        {
            missionTime -= Time.deltaTime;

            if (missionTimerText != null)
                missionTimerText.text = "Time: " + Mathf.Ceil(missionTime).ToString();


            if (missionTime <= 1 &&!hasWon)
            {
                hasWon = true;
                StartCoroutine(HandleVictory());   

                Debug.Log("🎉 Mission Complete! Victory Canvas shown.");

            }
        }
    }
    IEnumerator HandleVictory()
{
    GameObject player = GameObject.FindGameObjectWithTag("Player");
if (player != null)
    player.SetActive(false);

    if (clapAudio != null)
    {
    clapAudio.PlayOneShot(clapAudio.clip);
        Debug.Log("🔊 Clap Audio Played");
    }
    Debug.Log("🏁 HandleVictory() Started");

    if (missionUI != null)
        missionUI.SetActive(false);

    if (victoryCanvas != null)
        victoryCanvas.SetActive(true);


    // ننتظر عشان يشتغل الصوت كامل
    yield return new WaitForSecondsRealtime(5f);

    // نوقف اللعبة بعد الصوت
    Debug.Log("🛑 Game Paused");
}


    void SetEasyMode()
    {
        Time.timeScale = 1f;
        if (missionUI != null) missionUI.SetActive(false);
        if (victoryCanvas != null) victoryCanvas.SetActive(false);
    }

    void SetHardMode()
    {
        Time.timeScale = 1f;
        if (missionUI != null) missionUI.SetActive(false);
        if (victoryCanvas != null) victoryCanvas.SetActive(false);
    }

    void SetMissionMode()
    {
        Time.timeScale = 1f;
        if (missionUI != null) missionUI.SetActive(true);
        if (victoryCanvas != null) victoryCanvas.SetActive(false);
    }

}
