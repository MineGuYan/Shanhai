using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IllustratedClick : MonoBehaviour
{
    public TMP_Text text1;
    public TextAsset text1File;
    public TMP_Text text2;
    public TextAsset text2File;
    public Image image;
    public List<Sprite> R = new List<Sprite>();
    List<string> text1List = new List<string>();
    List<string> text2List = new List<string>();
    void Start()
    {
        var temp1Line=text1File.text.Split('\n');
        foreach(var line in temp1Line)
        {
            text1List.Add(line);
        }
        var temp2Line = text2File.text.Split('\n');
        foreach (var line in temp2Line)
        {
            text2List.Add(line);
        }
        Click(0);
    }

    void Update()
    {
        
    }

    public void Click(int index)
    {
        image.sprite = R[index];
        text1.text = text1List[index];
        text2.text = text2List[index];
    }
}
