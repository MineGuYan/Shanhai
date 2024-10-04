using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IllustratedClick : MonoBehaviour
{
    public TMP_Text t;
    public Image i;
    public Sprite R1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void R1click()
    {
        i.sprite = R1;
        t.text = "神兽昵称：宁宁\r\n神兽信息：好色，猪批，幻想减肥\r\n技能1：睡觉\r\n技能2：瑟瑟\r\n技能3：红温";
    }
}
