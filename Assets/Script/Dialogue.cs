using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BarrierClear : MonoBehaviour
{
    public TMP_Text text;
    public TextAsset textFile;
    public GameObject Role1;
    public GameObject Role2;
    public GameObject DialogBox;
    public bool isRole1;
    List<string> textList = new List<string>();
    int counter;
    void Start()
    {
        var tempLine = textFile.text.Split('\n');
        foreach (var line in tempLine)
        {
            textList.Add(line);
        }
        counter = 0;
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
        if (isRole1)
        {
            Role1.SetActive(true);
            Role2.SetActive(false);
            isRole1 = false;
        }
        else
        {
            Role1.SetActive(false);
            Role2.SetActive(true);
            isRole1 = true;
        }
        if (counter < textList.Count)
        {
            text.text = textList[counter++];
        }
        else
        {
            counter = 0;
            DialogBox.SetActive(false);
        }
    }
}
