using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeedY = 1.0f;

    void Update()
    {
        transform.Rotate(0, _rotateSpeedY, 0);
    }
}
