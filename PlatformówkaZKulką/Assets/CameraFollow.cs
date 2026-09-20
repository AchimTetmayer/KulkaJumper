using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 2, -10);

    void LateUpdate()
    {
        if (target != null)
        {
            // Aktualizuj tylko pozycję, zachowując własną rotację
            transform.position = target.position + offset;
        }
    }
}
