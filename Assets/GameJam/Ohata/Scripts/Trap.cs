using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField]
    [Header("Playerがトラップに掛かった時")]
    string _Trap = "trap";
    [SerializeField]
    Animator _anim;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.GameOver();
        _anim.Play(_Trap);
    }
}
