using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    [Header("依赖对象")]
    [Tooltip("任务栏")] public GameObject task;
    [Tooltip("显示按钮")] public GameObject displayButton;
    [Tooltip("章节显示")] public TMP_Text TaskChap;
    [Tooltip("任务描述")] public TMP_Text TaskText;
    private bool isHide;

    [Header("任务列表")]
    public List<Tasks> tasks;

    [Header("任务进度")]
    public int chap, order;

    [System.Serializable]
    public class Tasks
    {
        [Tooltip("任务章节")] public string chapter;

        [Header("任务列表")]
        public List<TaskList> tasksList;

        [System.Serializable]
        public class TaskList
        {
            [Tooltip("任务序号")] public string taskNumber;
            [Tooltip("任务描述")] public string description;
        }
    }


    
    void Start()
    {
        isHide = false;
        TaskDescriptionShow();
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

    public void TaskDescriptionShow()
    {
        TaskChap.text = tasks[chap].chapter;
        TaskText.text = tasks[chap].tasksList[order].taskNumber+"\n"+ tasks[chap].tasksList[order].description;
    }
}
