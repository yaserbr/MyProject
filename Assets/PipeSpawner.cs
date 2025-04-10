using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

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
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {

        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(12, randomY, 0);
        Instantiate(Pipe, spawnPosition, Quaternion.identity);

    }
}
