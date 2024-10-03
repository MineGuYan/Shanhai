using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanel : MonoBehaviour
{
   public void OnCloseHandler()
    {
        gameObject.SetActive(false);
    }
}
