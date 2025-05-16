
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerController : MonoBehaviour
{
    public float jumpForce = 12f;
    private Rigidbody2D rb;
    private bool hasLost = false;
    private bool canLose = false;
    public AudioSource collisionSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(EnableLossAfterDelay());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasLost)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
            Debug.Log("Space key pressed — character jumps");
        }
    }

    IEnumerator EnableLossAfterDelay()
    {
        yield return new WaitForSeconds(0.5f);  // 0.5 ثانية تأخير
        canLose = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasLost || !canLose) return;

        hasLost = true;

        if (collisionSound != null)
            collisionSound.Play();

        Time.timeScale = 0f;

        var logic = GameObject.FindGameObjectWithTag("Logic")?.GetComponent<LogicManager>();
        if (logic != null)
        {
            logic.gameOver();
        }
    }

//     private void OnTriggerEnter2D(Collider2D other)
// {
//     Debug.Log("Triggered with: " + other.gameObject.name);  // طباعة اسم الكائن المتصادم
//     // تأكد من أن التصادم مع Tag "Pipe" فقط
//     if (pointGiven || !other.CompareTag("Pipe")) return;

//     pointGiven = true;
//     Debug.Log("✅ Point added from mid pipe trigger");

//     var logic = GameObject.FindGameObjectWithTag("Logic")?.GetComponent<LogicManager>();
//     if (logic != null)
//     {
//         logic.addScore(1);
//         Debug.Log("Score increased!");
//     }
// }

}
