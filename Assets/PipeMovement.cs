using UnityEngine;

public class PipeMovement : MonoBehaviour
{
<<<<<<< HEAD
    float moveSpeed;

    void Start()
    {
        switch (GameModeManager.SelectedMode)
        {
            case GameModeManager.GameMode.Easy:
                moveSpeed = 2.5f;
                break;
            case GameModeManager.GameMode.Hard:
                moveSpeed = 5f;
                break;
            case GameModeManager.GameMode.Mission:
                moveSpeed = 3.5f;
                break;
        }
=======
    public float MoveSpeed = 2;               // سرعة حركة الأنبوب
               // أعلى ارتفاع للأنبوب


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

>>>>>>> 81ff3eac189a0dddcb4a052e8d2228c36c2e2f7d
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

    }

}
=======
        transform.position += Vector3.left * MoveSpeed * Time.deltaTime;

    }
}
>>>>>>> 81ff3eac189a0dddcb4a052e8d2228c36c2e2f7d
