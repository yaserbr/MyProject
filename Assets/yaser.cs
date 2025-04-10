using UnityEngine;

public class yaser : MonoBehaviour
{
    public Rigidbody2D myRig;
    public float myFloatNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRig.linearVelocity = Vector2.up * myFloatNumber;
        }
    }
}
