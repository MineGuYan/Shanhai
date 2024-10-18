using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class DiaTrigger : MonoBehaviour
{
    public TextAsset textFile;
    public GameObject DialogBox;
    public TaskManager.TaskProgress Progress;
    private Rigidbody2D RBody;
    void Start()
    {
        RBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) FindPlayer();     
    }
    public void TextTrigger()
    {
        Debug.Log("Find");
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
    }
}
