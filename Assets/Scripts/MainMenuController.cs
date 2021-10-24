using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void PlayBtn1()
    {
        LoadingManager.Instance.LoadTo("Level_1");
    }

    public void PlayBtn2()
    {
        LoadingManager.Instance.LoadTo("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}