using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [Header("��������")]
    public GameObject task;
    public GameObject displayButton;
    private bool isHide;

    [Header("�����б�")]
    public List<Tasks> tasks;

    [System.Serializable]
    public class Tasks
    {
        [Header("�����½�")]
        public string chapter;

        [Header("�����б�")]
        public List<TaskList> tasksList;

        [System.Serializable]
        public class TaskList
        {
            [Header("����")]
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
