using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class DiaTrigger : MonoBehaviour
{
    public TextAsset textFile;
    public GameObject DialogBox;
    public TaskManager.TaskProgress Progress;
    private Rigidbody2D RBody;

    [Header("1.3")]
    public GameObject mogu;
    void Start()
    {
        RBody = GetComponent<Rigidbody2D>();

        TaskManager.TaskProgress temp = new TaskManager.TaskProgress(1,3);
        if (TaskManager.instance.taskProgress > temp) BeforeTaskFun1_3();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) FindPlayer();     
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

    public void FindPlayer()
    {
        Collider2D collider = Physics2D.OverlapCircle(RBody.position, 1f, LayerMask.GetMask("Role"));
        if (collider != null && collider.name == "Player") TextTrigger();

        if (Progress.chap == 1 && Progress.order == 3) BeforeTaskFun1_3();
    }

    public void BeforeTaskFun1_3()
    {
        mogu.SetActive(false);
    }
}
