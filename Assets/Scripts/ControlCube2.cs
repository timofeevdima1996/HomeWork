using UnityEngine;

public class ControlCube2 : MonoBehaviour
{
    [SerializeField] private float speedIncriase = 0.5f;
    [SerializeField] private float maxSize = 1.5f;
    [SerializeField] private float minSize = 0.5f;
    private bool isLimitIncriase = true;

    [SerializeField] private float angleRotation = 30f;
    [SerializeField] private float radius = 2f;
    private Vector3 startingPositionCube2;

    void Start()
    {
        startingPositionCube2 = transform.position;
    }

    void Update()
    {
        var scale = transform.localScale;

        if (isLimitIncriase)
        {
            scale += new Vector3(speedIncriase, speedIncriase, speedIncriase) * Time.deltaTime;
            transform.localScale = scale;
            if (transform.localScale.y >= maxSize)
            {
                isLimitIncriase = false;
            }
        }
        else if (!isLimitIncriase) 
        {
            scale -= new Vector3(speedIncriase, speedIncriase, speedIncriase) * Time.deltaTime;
            transform.localScale = scale;
            if ( transform.localScale.y <= minSize)
            {
                isLimitIncriase = true;
            }
        }

        Vector3 centerRotation = new (startingPositionCube2.x, startingPositionCube2.y + radius, startingPositionCube2.z) ;

        transform.RotateAround(centerRotation, Vector3.right, angleRotation * Time.deltaTime);
    }
}
