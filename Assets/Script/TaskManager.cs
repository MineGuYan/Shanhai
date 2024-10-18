using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System;

public class TaskManager : MonoBehaviour
{
    public static TaskManager instance;
    public delegate void TaskFinishFunction();

    [Header("��������")]
    [Tooltip("������")] public GameObject task;
    [Tooltip("��ʾ��ť")] public GameObject displayButton;
    [Tooltip("�½���ʾ")] public TMP_Text TaskChap;
    //[Tooltip("�½�������ʾ")] public TMP_Text TaskChapName;
    [Tooltip("����������ʾ")] public TMP_Text TaskText;
    private bool isHide;

    [Header("�����б�")]
    public List<Tasks> tasks;

    [Header("�������")]
    public TaskProgress taskProgress;

    [System.Serializable]
    public class TaskProgress
    {
        public int chap;
        public int order;

        public TaskProgress(int chap, int order)
        {
            this.chap = chap;
            this.order = order;
        }

        public static bool operator ==(TaskProgress a, TaskProgress b)
        {
            if(a.chap == b.chap&&a.order==b.order)return true;
            return false;
        }
        public static bool operator !=(TaskProgress a, TaskProgress b)
        {
            if (a.chap == b.chap && a.order == b.order) return false;
            return true;
        }
        public static bool operator >(TaskProgress a, TaskProgress b)
        {
            if (a.chap > b.chap) return true;
            else if (a.chap == b.chap && a.order > b.order) return true;
            return false;
        }
        public static bool operator <(TaskProgress a, TaskProgress b)
        {
            if (a.chap < b.chap) return true;
            else if (a.chap == b.chap && a.order < b.order) return true;
            return false;
        }
        public static bool operator >=(TaskProgress a, TaskProgress b)
        {
            if (a.chap > b.chap) return true;
            else if (a.chap == b.chap && a.order >= b.order) return true;
            return false;
        }
        public static bool operator <=(TaskProgress a, TaskProgress b)
        {
            if (a.chap < b.chap) return true;
            else if (a.chap == b.chap && a.order <= b.order) return true;
            return false;
        }
    }

    [System.Serializable]
    public class Tasks
    {
        [Tooltip("�����½�")] public string chapter;
        //[Tooltip("�½�����")] public string chapName;

        [Header("�����б�")]
        public List<TaskList> tasksList;

        [System.Serializable]
        public class TaskList
        {
            [TextArea]
            [Tooltip("��������")] public string description;
            public TaskFinishFunction TFF;
        }
    }

    private void Awake()
    {
        instance = this;
        LoadTaskProgress();
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
        TaskChap.text = tasks[taskProgress.chap].chapter;
        //TaskChapName.text = tasks[taskProgress.chap].chapName;
        TaskText.text = tasks[taskProgress.chap].tasksList[taskProgress.order].description;
    }

    public void SaveTaskProgress()
    {
        String json = JsonUtility.ToJson(taskProgress);
        String filePath = Application.streamingAssetsPath + "/taskprogress.json";

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine(json);
            sw.Close();
            sw.Dispose();
        }
    }

    public void LoadTaskProgress()
    {
        string json;
        String filePath = Application.streamingAssetsPath + "/taskprogress.json";

        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                json = sr.ReadToEnd();
                sr.Close();
            }
            taskProgress = JsonUtility.FromJson<TaskProgress>(json);
        }
        else
        {
            taskProgress.chap = 0;
            taskProgress.order = 0;
        }
    }

    public void TaskFinish()
    {
        if (tasks[taskProgress.chap].tasksList[taskProgress.order].TFF != null) tasks[taskProgress.chap].tasksList[taskProgress.order].TFF();
        if (++taskProgress.order == tasks[taskProgress.chap].tasksList.Count)
        {
            taskProgress.order = 0;
            taskProgress.chap++;
        }
        SaveTaskProgress();
        TaskDescriptionShow();
    }
}