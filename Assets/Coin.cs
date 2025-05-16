using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points = 1; // عدد النقاط التي يحصل عليها اللاعب عند جمع العملة

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // تأكد من أن الكائن الذي يصطدم بالعملة هو اللاعب
        {
            LogicManager logic = GameObject.FindGameObjectWithTag("Logic")?.GetComponent<LogicManager>();
            if (logic != null)
            {
                logic.AddCoinScore(points);  // إضافة النقاط إلى العداد
            }
            Destroy(gameObject);  // تدمير العملة بعد جمعها
        }
    }
}
