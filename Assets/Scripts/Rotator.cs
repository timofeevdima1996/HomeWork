using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotateSpeedY = 1.0f;

    void Update()
    {
        transform.Rotate(0, rotateSpeedY, 0);
    }
}
