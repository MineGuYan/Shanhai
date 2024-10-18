using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskFinishControl : MonoBehaviour
{
    [Header("1.1")]
    public GameObject xiaoyao1;
    public GameObject xiaoyao2;
    void Start()
    {
        TaskManager.instance.tasks[1].tasksList[0].TFF = Fun1_0;
    }

    void Update()
    {
        
    }

    public void Fun1_0()
    {
        xiaoyao1.SetActive(false);
        xiaoyao2.SetActive(true);
    }
}
