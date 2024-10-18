using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTrigger : MonoBehaviour
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
    }
}
