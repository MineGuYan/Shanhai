using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownControl : MonoBehaviour
{
    public GameObject yishou1;
    public GameObject yishou2;
    public GameObject yiwen1;
    public GameObject yiwen2;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void changePages()
    {
        if(yishou1.activeSelf)
        {
            yishou1.SetActive(false);
            yishou2.SetActive(false);
            yiwen1.SetActive(true);
            yiwen2.SetActive(true);
        }
        else
        {
            yishou1.SetActive(true);
            yishou2.SetActive(true);
            yiwen1.SetActive(false);
            yiwen2.SetActive(false);
        }
    }
}
