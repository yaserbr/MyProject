using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; // إذا تستخدم TextMeshPro

public class GameModeHandler : MonoBehaviour
{
    public GameObject missionUI;
    public TMP_Text missionTimerText; // استخدم Text إذا ما تستخدم TextMeshPro
    public float missionTime = 20f;

    public GameObject victoryCanvas;

    void Start()
    {
        // ضبط الإعدادات حسب المود
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
        // تشغيل العداد في وضع المهمة فقط
        if (GameModeManager.SelectedMode == GameModeManager.GameMode.Mission)
        {
            missionTime -= Time.deltaTime;

            if (missionTimerText != null)
                missionTimerText.text = "Time: " + Mathf.Ceil(missionTime).ToString();

            if (missionTime <= 0)
            {
                Time.timeScale = 0f;

                if (missionUI != null)
                    missionUI.SetActive(false);

                if (victoryCanvas != null)
                    victoryCanvas.SetActive(true);

                Debug.Log("🎉 Mission Complete! Victory Canvas shown.");
            }
        }
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
