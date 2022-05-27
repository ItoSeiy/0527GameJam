using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanayaSample : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))// 右移動
        {
            transform.position += new Vector3(speed,0,0);
        }
        if(Input.GetKey(KeyCode.A))//左移動
        {
            transform.position += new Vector3(-speed, 0, 0);
        }
    }
}
