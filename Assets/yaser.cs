using UnityEngine;
using System.Collections;

public class yaser : MonoBehaviour
{
    public Rigidbody2D myRig;
    public LogicManager logic;
    public float myFloatNumber;
    public AudioSource collisionSound;

    private bool hasLost = false;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRig.linearVelocity = Vector2.up * myFloatNumber;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasLost)
        {
            hasLost = true;

            // 1. تشغيل صوت التصادم (الانفجار)
            if (collisionSound != null)
                collisionSound.Play();

            // 2. تشغيل تأخير وإظهار شاشة الخسارة مع صوت الخسارة
            StartCoroutine(HandleLoss());
        }
    }

    IEnumerator HandleLoss()
    {
        // نوقف اللعبة فورًا
        Time.timeScale = 0f;

        // ننتظر 2 ثانية حقيقية
        yield return new WaitForSecondsRealtime(1f);

        // بعدها نشغل صوت الخسارة ونظهر شاشة الخسارة
        if (logic != null)
            logic.gameOver();
    }
}