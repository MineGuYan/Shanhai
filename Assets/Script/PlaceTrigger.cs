using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTrigger : MonoBehaviour
{
    public TextAsset textFile;
    public GameObject DialogBox;
    public TaskManager.TaskProgress Progress;

    [Header("1.2&1.4")]
    public GameObject tongtong;
    void Start()
    {
        TaskManager.TaskProgress temp1 = new TaskManager.TaskProgress(1, 2);
        if (TaskManager.instance.taskProgress > temp1) BeforeTaskFun1_2();
        TaskManager.TaskProgress temp2 = new TaskManager.TaskProgress(1, 4);
        if (TaskManager.instance.taskProgress > temp2) BeforeTaskFun1_4();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (textFile != null && Progress == TaskManager.instance.taskProgress)
        {
            var tempLine = textFile.text.Split('\n');
            foreach (var line in tempLine)
            {
                Dialogue.textList.Add(line);
            }
            Time.timeScale = 0.0f;
            DialogBox.SetActive(true);
        }

        if (Progress.chap == 1 && Progress.order == 2) BeforeTaskFun1_2();
        if (Progress.chap == 1 && Progress.order == 4) BeforeTaskFun1_4();
    }

    public void BeforeTaskFun1_2()
    {
        tongtong.SetActive(false);
    }
    public void BeforeTaskFun1_4()
    {
        tongtong.SetActive(true);
    }
}
