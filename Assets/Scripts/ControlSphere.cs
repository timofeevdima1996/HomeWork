using System.Runtime.CompilerServices;
using UnityEngine;

public class ControlSphere : MonoBehaviour
{
    [SerializeField] private float speedSphere = 0.05f;
    [SerializeField] private float amplitudePlus = 10f;
    [SerializeField] private float amplitudeMinus = -10f;
    private bool chooseDirection = true;

    void Start()
    {

    }

    void Update()
    {
        var nextPosition = transform.position;

        if (chooseDirection)
        {
            nextPosition.z += speedSphere;
            transform.position = nextPosition;

            if (nextPosition.z > amplitudePlus)
            {
                chooseDirection = false;
            }
        }
        else if (!chooseDirection)
        {
            nextPosition.z -= speedSphere;
            transform.position = nextPosition;

            if (nextPosition.z < amplitudeMinus)
            {
                chooseDirection = true;
            }
        }
    }
}
