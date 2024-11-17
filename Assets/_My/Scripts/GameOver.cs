using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void quit()
    {
        Application.Quit();
    }
}


