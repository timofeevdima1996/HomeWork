using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
