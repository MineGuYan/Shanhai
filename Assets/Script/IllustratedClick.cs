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
        t.text = "�����ǳƣ�����\r\n������Ϣ����ɫ���������������\r\n����1��˯��\r\n����2��ɪɪ\r\n����3������";
    }
}
