using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;  // العملة التي سيتم نسخها
    public float spawnRate = 2f;   // معدل التوليد (بالثواني)
    public float minY = -2f;       // الحد الأدنى للموقع العمودي للعملة
    public float maxY = 2f;        // الحد الأقصى للموقع العمودي للعملة
    private float timer = 0f;





    void Update()
    {
         timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnCoin();
            timer = 0f;
        }
    }

    void SpawnCoin()
    {
        float randomY = Random.Range(minY, maxY);  // تحديد موقع عشوائي للعملة بين الأنابيب
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0);
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);  // توليد العملة
    }
}
