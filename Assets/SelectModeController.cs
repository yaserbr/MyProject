using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectModeController : MonoBehaviour
{
    public GameObject newLevelButton;
    public void SelectEasy()
    {
        GameModeManager.SelectedMode = GameModeManager.GameMode.Easy;
        SceneManager.LoadScene("PlayScene");
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
    public void SelectLevel2()
    {
        GameModeManager.SelectedMode = GameModeManager.GameMode.Easy;
        SceneManager.LoadScene("PlayScene2");
    }
    void Start()
    {
        int coins = PlayerPrefs.GetInt("CoinsCollected", 0);
        if (coins >= 5)
        {
            newLevelButton.SetActive(true);
        }
       
    }


}
