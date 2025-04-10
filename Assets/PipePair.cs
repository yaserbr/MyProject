using UnityEngine;

public class PipePair : MonoBehaviour
{
    public Transform topPipe;
    public Transform bottomPipe;

    public void SetGap(float gap)
    {
        if (topPipe != null && bottomPipe != null)
        {
            topPipe.localPosition = new Vector3(0, gap / 2f, 0);
            bottomPipe.localPosition = new Vector3(0, -gap / 2f, 0);
        }
    }
}