using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // يخلي الموسيقى تستمر بين المشاهد
        }
        else
        {
            Destroy(gameObject); // يمنع التكرار إذا انتقلت بين المشاهد
        }
    }
}
