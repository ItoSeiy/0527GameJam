using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchController : MonoBehaviour
{
    [SerializeField] UnityEvent _onEnter = default;

    bool _isMove = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(!_isMove)
            {
                _onEnter.Invoke();
                _isMove = true;
            }
        }
    }
}
