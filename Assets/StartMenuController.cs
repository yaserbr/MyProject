using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        // تأكد أن اسم المشهد يطابق تمامًا اسم الملف في مجلد Scenes
        SceneManager.LoadScene("PlayScene"); 
    }

    public void OpenSelectMode()
    {
        SceneManager.LoadScene("SelectMode");
    }
}
