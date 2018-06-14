using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageController
{
    public static void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }

    public static void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public static void GoTo(PageName name)
    {
        Debug.Log(name.ToString());
        SceneManager.LoadScene(name.ToString());
    }
}