using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public PageName lastPageName;

    public void OnClickBackBtn()
    {
        PageController.GoTo(lastPageName);
    }

    public void OnClickHomeBtn()
    {
        PageController.GoToHome();
    }

    public void OnClickBoyPortrait()
    {
        PageController.GoToBoyMain();
    }

    public void OnClickGirlPortrait()
    {
        PageController.GoToGirlMain();
    }

    public void OnClickParentCenterBtn()
    {
        PageController.GoToParentCenter();
    }

    public void OnClickBoyShowerBtn()
    {
        PageController.GoToBoyShower();
    }

    public void OnClickBoyToiletBtn()
    {
        PageController.GoToBoyToilet();
    }

    public void OnClickBoyClosetBtn()
    {
        PageController.GoToBoyCloset();
    }

    public void OnClickBoyShowerToClosetBtn()
    {
        PageController.GoToBoyShowerToCloset();
    }

    public void OnClickBoyLostBtn()
    {
        PageController.GoToBoyLost();
    }

    public void OnClickBoyBookBtn()
    {
        PageController.GoToBoyBook();
    }

    public void OnClickGirlShowerBtn()
    {
        PageController.GoToGirlShower();
    }

    public void OnClickGirlToiletBtn()
    {
        PageController.GoToGirlToilet();
    }

    public void OnClickGirlClosetBtn()
    {
        PageController.GoToGirlCloset();
    }

    public void OnClickGirlShowerToClosetBtn()
    {
        PageController.GoToGirlShowerToCloset();
    }

    public void OnClickGrilLostBtn()
    {
        PageController.GoToGirlLost();
    }

    public void OnClickGirlBookBtn()
    {
        PageController.GoToGirlBook();
    }
}