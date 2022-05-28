using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KanayaSample : MonoBehaviour
{
    [SerializeField] Text ClearText;
    [SerializeField] GameObject _RetryButton;
    // Start is called before the first frame update
    void Start()
    {
        _RetryButton.SetActive(false);
        ClearText.enabled = false;
        Invoke("GameClear", 5.5f);
    }
    public void GameClear()
    {
        ClearText.enabled = true;
        _RetryButton.SetActive(true);
    }
    public void Retry()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
