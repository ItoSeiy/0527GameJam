using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] string _sceneName;
    [SerializeField] GameObject _button;
    void Start()
    {
        Invoke("IsActive", 5f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void IsActive()
    {
        _button.SetActive(true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
