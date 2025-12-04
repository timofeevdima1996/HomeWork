using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class Clock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private float _step = 1f;

    private float _number = 0f;
    private bool _isWork;
    private Coroutine _counterCoroutine;

    void Start()
    {
        _isWork = true;
        _text.text = _number.ToString();
        _counterCoroutine = StartCoroutine(Counter());
    }

    private IEnumerator Counter()
    {
        while (true)
        {
            if (_isWork)
            {
                _number += _step;
                _text.text = _number.ToString();
            }

            yield return new WaitForSeconds(_delay);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W pressed");
            _isWork = !_isWork;
        }
    }

    void OnDestroy()
    {
        if (_counterCoroutine != null)
        {
            StopCoroutine(_counterCoroutine);
        }
    }
}
