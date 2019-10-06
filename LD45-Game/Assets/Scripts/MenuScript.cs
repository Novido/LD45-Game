using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    

    public void OnClick(string scene)
    {
        SceneManager.LoadScene(scene);
    }       

    public void ExitApp()
    {
        Application.Quit();
    }
}
