using UnityEngine;

public class Pulsator : MonoBehaviour
{
    [SerializeField] private float _speedIncrease = 0.4f;
    [SerializeField] private float _scaleMax = 1.5f;
    [SerializeField] private float _scaleMin = 0.5f;

    private bool _isLimitIncrease = false;

    void Update()
    {
        var scale = transform.localScale;

        if (_isLimitIncrease)
        {
            scale += new Vector3(_speedIncrease, _speedIncrease, _speedIncrease) * Time.deltaTime;
            transform.localScale = scale;
            
            if (transform.localScale.x >= _scaleMax)
            {
                _isLimitIncrease = false;
            }
        }
        else if (!_isLimitIncrease)
        {
            scale -= new Vector3(_speedIncrease, _speedIncrease, _speedIncrease) * Time.deltaTime;
            transform.localScale = scale;
            
            if (transform.localScale.x <= _scaleMin)
            {
                _isLimitIncrease = true;
            }
        }
    }
}
