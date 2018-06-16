using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageController
{
    public static void GoToHome()
    {
        SceneManager.LoadScene(PageName.Home.ToString());
    }

    public static void GoToParentCenter()
    {
        SceneManager.LoadScene(PageName.ParentCenter.ToString());
    }

    public static void GoToBoyMain()
    {
        SceneManager.LoadScene(PageName.BoyMain.ToString());
    }

    public static void GoTo(PageName name)
    {
        Debug.Log(name.ToString());
        SceneManager.LoadScene(name.ToString());
    }


    public static void GoToBoyShower()
    {
        SceneManager.LoadScene(PageName.BoyShower.ToString());
    }

    public static void GoToBoyToilet()
    {
        SceneManager.LoadScene(PageName.BoyToilet.ToString());
    }

    public static void GoToBoyCloset()
    {
        SceneManager.LoadScene(PageName.BoyCloset.ToString());
    }

    public static void GoToBoyShowerToCloset()
    {
        SceneManager.LoadScene(PageName.BoyShowerToCloset.ToString());
    }

    public static void GoToBoyLost()
    {
        SceneManager.LoadScene(PageName.BoyLost.ToString());
    }

    public static void GoToBoyBook()
    {
        SceneManager.LoadScene(PageName.BoyBook.ToString());
    }

    public static void GoToGirlMain()
    {
        SceneManager.LoadScene(PageName.GirlMain.ToString());
    }


    public static void GoToGirlShower()
    {
        SceneManager.LoadScene(PageName.GirlShower.ToString());
    }

    public static void GoToGirlToilet()
    {
        SceneManager.LoadScene(PageName.GirlToilet.ToString());
    }

    public static void GoToGirlCloset()
    {
        SceneManager.LoadScene(PageName.GirlCloset.ToString());
    }

    public static void GoToGirlShowerToCloset()
    {
        SceneManager.LoadScene(PageName.GirlShowerToCloset.ToString());
    }

    public static void GoToGirlLost()
    {
        SceneManager.LoadScene(PageName.GirlLost.ToString());
    }

    public static void GoToGirlBook()
    {
        SceneManager.LoadScene(PageName.GirlBook.ToString());
    }
}