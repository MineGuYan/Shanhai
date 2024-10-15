using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTalk : MonoBehaviour
{
    private Animator An;
    private Rigidbody2D RBody;
    // Start is called before the first frame update
    void Start()
    {
        An = GetComponent<Animator>();
        RBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Talk();
        }
    }
    public void Talk()
    {
        Collider2D collider = Physics2D.OverlapCircle(RBody.position, 0.5f, LayerMask.GetMask("NPC"));
        if (collider != null)
        {
            if (collider.name == "TongTong")
            {
                collider.GetComponent<DiaTrigger>().TextTrigger();
            }
            if (collider.name == "QiuYu")
            {
                collider.GetComponent<DiaTrigger>().TextTrigger();
            }
            if (collider.name == "XingXing")
            {
                collider.GetComponent<DiaTrigger>().TextTrigger();
            }
            if (collider.name == "GeGe")
            {
                collider.GetComponent<DiaTrigger>().TextTrigger();
            }
        }
    }
}
