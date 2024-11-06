using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start1 : MonoBehaviour
{

    public void GameStart1()
    {
        SceneManager.LoadScene("_Base");
    }
    public void GameStart2()
    {
        SceneManager.LoadScene("_Base2");
    }

    public void GameExit()
    {
        Application.Quit();
    }



}
