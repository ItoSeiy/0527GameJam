using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    [SerializeField] string _sceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
