using UnityEngine;

public class ControlCapsule : MonoBehaviour
{
    [SerializeField] private float speedIncrease = 0.4f;
    [SerializeField] private float scaleMax = 1.5f;
    [SerializeField] private float scaleMin = 0.5f;
    private bool isLimitIncrease = false;

    void Start()
    {
        
    }

    void Update()
    {
        var scale = transform.localScale;

        if (isLimitIncrease)
        {
            scale += new Vector3(speedIncrease, speedIncrease, speedIncrease) * Time.deltaTime;
            transform.localScale = scale;
            if (transform.localScale.x >= scaleMax)
            {
                isLimitIncrease = false;
            }
        }
        else if (!isLimitIncrease)
        {
            scale -= new Vector3(speedIncrease, speedIncrease, speedIncrease) * Time.deltaTime;
            transform.localScale = scale;
            if (transform.localScale.x <= scaleMin)
            {
                isLimitIncrease = true;
            }
        }
    }
}
