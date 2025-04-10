using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
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

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            spawnPipe();
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
    }
}
