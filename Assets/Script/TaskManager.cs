using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    [Header("��������")]
    [Tooltip("������")] public GameObject task;
    [Tooltip("��ʾ��ť")] public GameObject displayButton;
    [Tooltip("�½���ʾ")] public TMP_Text TaskChap;
    [Tooltip("��������")] public TMP_Text TaskText;
    private bool isHide;

    [Header("�����б�")]
    public List<Tasks> tasks;

    [Header("�������")]
    public int chap, order;

    [System.Serializable]
    public class Tasks
    {
        [Tooltip("�����½�")] public string chapter;

        [Header("�����б�")]
        public List<TaskList> tasksList;

        [System.Serializable]
        public class TaskList
        {
            [Tooltip("�������")] public string taskNumber;
            [Tooltip("��������")] public string description;
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
