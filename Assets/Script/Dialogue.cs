using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TMP_Text text;
    public GameObject DialogBox;
    public static List<string> textList = new List<string>();
    int counter = 0;
    void OnEnable()
    {
        NextDiolog();
    }

    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
           NextDiolog();
        }
    }

    void NextDiolog()
    {
        if (counter < textList.Count)
        {
            text.text = textList[counter++];
        }
        else
        {
            counter = 0;
            textList.Clear();
            Time.timeScale = 1.0f;
            DialogBox.SetActive(false);
            TaskManager.instance.TaskFinish();
        }
    }
}
