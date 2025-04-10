using Unity.VisualScripting;
using UnityEngine;

public class yaser : MonoBehaviour
{
    public Rigidbody2D myRig;
    public LogicManager logic;

    public float myFloatNumber;
    public AudioSource collisionSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRig.linearVelocity = Vector2.up * myFloatNumber;
        }
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        collisionSound.Play();   // يشغّل صوت الاصطدام
        logic.gameOver();        // بعدها يوقف اللعبة ويظهر شاشة الخسارة
    }

}