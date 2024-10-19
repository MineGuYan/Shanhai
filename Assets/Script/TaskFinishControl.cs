using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskFinishControl : MonoBehaviour
{
    [Header("1.0")]
    public GameObject xiaoyao1;
    public GameObject xiaoyao2;
    void Start()
    {
        TaskManager.instance.tasks[1].tasksList[0].TFF = Fun1_0;
        TaskManager.TaskProgress temp1 = new TaskManager.TaskProgress(1, 0);
        if (TaskManager.instance.taskProgress > temp1) Fun1_0();
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
