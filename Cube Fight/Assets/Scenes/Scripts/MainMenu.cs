using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Start(int index)
    {
        Load.sceneNum = 2;
        SceneManager.LoadScene(index);
    }

    public void Settings()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }

}