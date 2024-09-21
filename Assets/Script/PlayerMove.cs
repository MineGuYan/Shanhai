using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator An;
    private Rigidbody2D RBody;
    void Start()
    {
        An= GetComponent<Animator>();
        RBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if(horizontal != 0|| vertical != 0)
        {
            An.SetFloat("Horizontal", horizontal);
            An.SetFloat("Vertical", vertical);
            An.SetBool("Walk", true);
        }
        else An.SetBool("Walk", false);
        Vector2 dir=new Vector2(horizontal, vertical);
        RBody.velocity= dir * 3f;
    }
}
