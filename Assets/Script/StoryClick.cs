using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryClick : MonoBehaviour
{
    public Image image;
    public TMP_Text text;
    public List<Sprite> R = new List<Sprite>();
    public List<string> textList = new List<string>();
    public static StoryClick instance;
    public int Index;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Click(0);
    }

    void Update()
    {
        
    }
    public void Click(int index)
    {
        Index = index;
        image.sprite = R[index];
        text.text = textList[index];
    }
}
