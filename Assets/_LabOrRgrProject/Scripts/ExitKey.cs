using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitKey : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("escape"))
            SceneManager.LoadScene("MainMenu");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}



