using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KanayaSample : MonoBehaviour
{
    [SerializeField] Text ClearText;
    // Start is called before the first frame update
    void Start()
    {
        ClearText.enabled = false;
        Invoke("GameClear", 5.5f);
    }
    public void GameClear()
    {
        ClearText.enabled = true;
    }

}
