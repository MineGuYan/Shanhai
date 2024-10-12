using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IllustrateMenu : MonoBehaviour
{
    public void OpenIllustrate()
    {
        SceneManager.LoadScene(2);
    }
    public void CloseIllustrate()
    {
        SceneManager.LoadScene(1);
    }
}
