using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBarrier : MonoBehaviour
{
    public GameObject barrier;
    public TaskManager.TaskProgress progress;
    void Start()
    {
        if(TaskManager.instance.taskProgress > progress)BarrierClear();
        else TaskManager.instance.tasks[progress.chap].tasksList[progress.order].TFF = BarrierClear;        
    }

    public void BarrierClear()
    {
        barrier.SetActive(false);
    }
}