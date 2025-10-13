using UnityEngine;

public class ControlCube1 : MonoBehaviour
{
    [SerializeField] private float rotateSpeedY = 1.0f;

    private void Update()
    {
        transform.Rotate(0, rotateSpeedY, 0);
    }
}
