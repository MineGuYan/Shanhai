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
        if (TaskManager.instance.taskProgress > temp1 && tongtong != null) BeforeTaskFun1_2();
        TaskManager.TaskProgress temp2 = new TaskManager.TaskProgress(1, 4);
        if (TaskManager.instance.taskProgress > temp2 && tongtong != null) BeforeTaskFun1_4();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
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

        if (TaskManager.instance.taskProgress.chap == 1 && TaskManager.instance.taskProgress.order == 2 && Progress == TaskManager.instance.taskProgress) BeforeTaskFun1_2();
        if (TaskManager.instance.taskProgress.chap == 1 && TaskManager.instance.taskProgress.order == 4 && Progress == TaskManager.instance.taskProgress) BeforeTaskFun1_4();
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
