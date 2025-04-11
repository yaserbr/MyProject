using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed;

// ss
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
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
