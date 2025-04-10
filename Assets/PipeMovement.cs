using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float MoveSpeed = 2;               // سرعة حركة الأنبوب
               // أعلى ارتفاع للأنبوب


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * MoveSpeed * Time.deltaTime;

    }
}
