using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class Clock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private float _step = 1f;

    private float _number = 0f;
    private bool _isCount = true;
    private bool _isWork;
    private bool _isStartCorutine = true;
    private Coroutine _counterCoroutine;

    private void Start()
    {
        _isWork = true;
        _text.text = _number.ToString();
        _counterCoroutine = StartCoroutine(Counter());
    }
    
    private void Update()
    {
        _isCount = Input.GetMouseButtonDown(0);
                
        if (_isCount)
        {
            Debug.Log("LKM pressed");
            _isWork = !_isWork;
        }
    }

    private IEnumerator Counter()
    {
        WaitForSeconds delay = new WaitForSeconds(_delay);
        
        while (_isStartCorutine)
        {
            if (_isWork)
            {
                _number += _step;
                _text.text = _number.ToString();
            }

            yield return delay;
        }
    }

    private void OnDestroy()
    {
        if (_counterCoroutine != null)
        {
            StopCoroutine(_counterCoroutine);
        }
    }

    private void GetInput()
    {

    }
}
