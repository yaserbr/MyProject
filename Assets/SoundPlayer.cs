using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusicController : MonoBehaviour
{
    public static BackgroundMusicController instance;

    public AudioSource mainMusic;       // الصوت الرئيسي
    public AudioSource levelMusic;      // صوت المستوى الجديد
    public string levelSceneName = "Level1";  // اسم مشهد المستوى الجديد

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);  // إذا نسخة ثانية موجودة، دمرها
        }
    }

    void OnDestroy()
    {
        if (instance == this)
            SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == levelSceneName)
        {
            if (mainMusic.isPlaying)
                mainMusic.Pause();  // أو Stop() حسب رغبتك

            if (!levelMusic.isPlaying)
                levelMusic.Play();
        }
        else
        {
            if (levelMusic.isPlaying)
                levelMusic.Stop();

            if (!mainMusic.isPlaying)
                mainMusic.UnPause();  // أو Play() حسب الطريقة اللي توقفته فيها
        }
    }
}
