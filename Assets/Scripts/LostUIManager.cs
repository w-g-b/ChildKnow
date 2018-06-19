using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LostUIManager : MonoBehaviour
{
    public GameObject womanPanel;
    public GameObject policePanel;
    public GameObject rightPanel;
    public GameObject errorPanel;
    public GameObject womanErrorPanel;
    public Text phoneNumber;
    public Animator boyAnimator;

    public void OnClickWomanOrOldmanBtn()
    {
        policePanel.SetActive(false);
        womanPanel.SetActive(true);
        rightPanel.SetActive(false);
        errorPanel.SetActive(false);
        womanErrorPanel.SetActive(false);
    }

    public void OnClickPoliceBtn()
    {
        policePanel.SetActive(true);
        womanPanel.SetActive(false);
        rightPanel.SetActive(false);
        errorPanel.SetActive(false);
        womanErrorPanel.SetActive(false);
    }

    public void OnClickWomanCloseBtn()
    {
        womanPanel.SetActive(false);
    }

    public void OnClickWomanRightBtn()
    {
        womanPanel.SetActive(false);
        womanErrorPanel.SetActive(true);
    }

    public void OnClickWomanErrorBtn()
    {
        womanPanel.SetActive(false);
        rightPanel.SetActive(true);
    }

    public void OnClickPoliceCloseBtn()
    {
        policePanel.SetActive(false);
        phoneNumber.text = "";
    }

    public void OnClickRightPanelCloseBtn()
    {
        rightPanel.SetActive(false);
    }

    public void OnClickErrorPanelCloseBtn()
    {
        errorPanel.SetActive(false);
    }

    public void OnClickWomanErrorPanelCloseBtn()
    {
        womanErrorPanel.SetActive(false);
    }

    public void OnClickCallBtn()
    {
        //TODO 判断电话号码是否正确
        var fatherPhone = PlayerPrefs.GetString("fatherPhone");
        var motherPhone = PlayerPrefs.GetString("motherPhone");
        if (fatherPhone.Length == 0 && motherPhone.Length == 0)
        {
            AndroidUtil.Toast("请去家长中心设置父母的电话号码~~~");
        }
        else
        {
            if (phoneNumber.text.Equals(fatherPhone) || phoneNumber.text.Equals(motherPhone))
            {
                policePanel.SetActive(false);
                rightPanel.SetActive(true);
                boyAnimator.SetBool("isSmile", true);
            }
            else
            {
                policePanel.SetActive(false);
                errorPanel.SetActive(true);
            }
        }
    }
}