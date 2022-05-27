using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandKey : MonoBehaviour
{
    private bool _Key;
    private bool _Touch;
    public GameObject _Panel;
    public Text _Text;
    void Start()
    {
        _Touch = false;
        _Key = false;
        _Panel.SetActive(false);
    }

    void Update()
    {
        
    }

    void GetItem()
    {
        // GameManager.Instance.GetKey();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player" && _Touch == false)
        {
            _Panel.SetActive(true);
        }
    }
    public void CommandYes()
    {
        GetItem();
        _Text.text = "鍵を見つけた";
        _Key = true;
        _Touch = true;
        _Panel.SetActive(false);
    }
    public void CommandNo()
    {
        _Panel.SetActive(false);
    }
}
