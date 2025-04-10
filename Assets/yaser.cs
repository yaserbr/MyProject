<<<<<<< HEAD
using Unity.VisualScripting;
=======
>>>>>>> 81ff3eac189a0dddcb4a052e8d2228c36c2e2f7d
using UnityEngine;

public class yaser : MonoBehaviour
{
    public Rigidbody2D myRig;
<<<<<<< HEAD
    public LogicManager logic;

    public float myFloatNumber;
    public AudioSource collisionSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
=======
    public float myFloatNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
>>>>>>> 81ff3eac189a0dddcb4a052e8d2228c36c2e2f7d

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRig.linearVelocity = Vector2.up * myFloatNumber;
        }
    }
<<<<<<< HEAD



    public void OnCollisionEnter2D(Collision2D collision)
    {
        collisionSound.Play();   // يشغّل صوت الاصطدام
        logic.gameOver();        // بعدها يوقف اللعبة ويظهر شاشة الخسارة
    }

}
=======
}
>>>>>>> 81ff3eac189a0dddcb4a052e8d2228c36c2e2f7d
