
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yaser : MonoBehaviour
{
    public Rigidbody2D myRig;
    public LogicManager logic;
    public float myFloatNumber;
    public AudioSource collisionSound;

    private bool hasLost = false;
    public GameObject[] characterPrefs;  // مصفوفة تحتوي على جميع الشخصيات
    public Transform spawnPoint;

    void Start()
    {
        GameObject logicObj = GameObject.FindGameObjectWithTag("Logic");
        if (logicObj != null)
        {
            logic = logicObj.GetComponent<LogicManager>();
            Debug.Log("Game started, LogicManager found");
        }

        int selectedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Debug.Log("Selected character index: " + selectedCharacterIndex);

        if (characterPrefs.Length == 0)
        {
            Debug.LogError("characterPrefs is empty! Add characters in the Inspector.");
            return;
        }

        if (selectedCharacterIndex >= 0 && selectedCharacterIndex < characterPrefs.Length)
        {
            GameObject selectedCharacter = Instantiate(characterPrefs[selectedCharacterIndex], spawnPoint.position, Quaternion.identity);
            Debug.Log("Character instantiated: " + selectedCharacter.name);

            // نحصل على Rigidbody2D تلقائيًا من الشخصية الجديدة
            // myRig = selectedCharacter.GetComponent<Rigidbody2D>();

            if (myRig == null)
                Debug.LogError("Rigidbody2D not found on instantiated character!");
        }
        else
        {
            Debug.LogError("Invalid character index: " + selectedCharacterIndex);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRig.linearVelocity = Vector2.up * myFloatNumber;
            Debug.Log("Space key pressed — character jumps");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
{
    // التحقق من أن الشخصية مرت من خلال الفجوة (مثلاً عبر أنبوب أو كائن مشابه)
    if (collision.CompareTag("Pipe"))  // تأكد من وضع الـ Tag الصحيح للفجوة في Unity
    {
        // زيادة العداد
        if (logic != null)
        {
            logic.addScore(1);  // زيادة العداد
        }
    }

    // التحقق من الاصطدامات الأخرى
    if (!hasLost)
    {
        hasLost = true;

        if (collisionSound != null)
            collisionSound.Play();

        StartCoroutine(HandleLoss());
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
