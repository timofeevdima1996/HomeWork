using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 2.0f;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
