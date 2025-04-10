using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectModeController : MonoBehaviour
{
    public void SelectEasy()
    {
        GameModeManager.SelectedMode = GameModeManager.GameMode.Easy;
        SceneManager.LoadScene("PlayScene"); // عدّل الاسم لو مشهدك اسمه غير
    }

    public void SelectHard()
    {
        GameModeManager.SelectedMode = GameModeManager.GameMode.Hard;
        SceneManager.LoadScene("PlayScene");
    }

    public void SelectMission()
    {
        GameModeManager.SelectedMode = GameModeManager.GameMode.Mission;
        SceneManager.LoadScene("PlayScene");
    }
}
