using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [Header("依赖对象")]
    public GameObject task;
    public GameObject displayButton;
    private bool isHide;

    [Header("任务列表")]
    public List<Tasks> tasks;

    [System.Serializable]
    public class Tasks
    {
        [Header("任务章节")]
        public string chapter;

        [Header("任务列表")]
        public List<TaskList> tasksList;

        [System.Serializable]
        public class TaskList
        {
            [Header("任务")]
            public string taskNumber;
            public string description;
        }
    }


    
    void Start()
    {
        isHide = false;
    }

    void Update()
    {
        
    }

    public void HideTaskPanel()
    {
        if (isHide)
        {
            task.SetActive(true);
            displayButton.SetActive(false);
            isHide = false;
        }
        else
        {
            task.SetActive(false);
            displayButton.SetActive(true);
            isHide = true;
        }
    }
}
