using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject Pipe;
    public float spawnRate = 2f;
    private float timer = 0f;

    public float minY = -1f;
    public float maxY = 3f;
    public float gapSize = 3f;

    void Start()
    {
        // نضبط الإعدادات حسب وضع اللعب
        switch (GameModeManager.SelectedMode)
        {
            case GameModeManager.GameMode.Easy:
                spawnRate = 3f;
                minY = 0f;
                maxY = 3.5f;
                gapSize = 5f;
                break;

            case GameModeManager.GameMode.Hard:
                spawnRate = 1f;
                minY = -2f;
                maxY = 2f;
                gapSize = 1.5f;
                break;

            case GameModeManager.GameMode.Mission:
                spawnRate = 2f;
                minY = -1f;
                maxY = 2.5f;
                gapSize = 3f;
                break;
        }
    }

=======

    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float minY = -1;
    public float maxY = 3;
    void Start()
    {

    }

    // Update is called once per frame
>>>>>>> 81ff3eac189a0dddcb4a052e8d2228c36c2e2f7d
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            spawnPipe();
<<<<<<< HEAD
            timer = 0f;
        }
    }

    void spawnPipe()
    {
        float y = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(12, y, 0);
        GameObject newPipe = Instantiate(Pipe, spawnPos, Quaternion.identity);

        // نرسل الفجوة إلى سكربت PipePair داخل prefab
        PipePair pipePair = newPipe.GetComponent<PipePair>();
        if (pipePair != null)
        {
            pipePair.SetGap(gapSize);
        }
=======
            timer = 0;
        }
    }
    void spawnPipe()
    {

        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(12, randomY, 0);
        Instantiate(Pipe, spawnPosition, Quaternion.identity);

>>>>>>> 81ff3eac189a0dddcb4a052e8d2228c36c2e2f7d
    }
}
