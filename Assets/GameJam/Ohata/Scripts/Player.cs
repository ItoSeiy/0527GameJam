using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rigidbody2d;
    private Animator animator;
    private Vector2 lookDirection = new Vector2(1, 0);

    [SerializeField]
    private float speed = 500f;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    void Update()
    {
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }

        animator.SetFloat("MoveX", lookDirection.x);
        animator.SetFloat("MoveY", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);

        rigidbody2d.velocity = new Vector2(horizontal, vertical).normalized * speed * Time.deltaTime;
    }

}