using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class DiaTrigger : MonoBehaviour
{
    public TextAsset textFile;
    public GameObject DialogBox;
    public TaskManager.TaskProgress Progress;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void TextTrigger()
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
    }
}
