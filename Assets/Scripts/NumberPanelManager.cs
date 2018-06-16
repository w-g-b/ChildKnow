using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPanelManager : MonoBehaviour
{
    public Text phoneNumber;

    public void OnClickOneBtn()
    {
        phoneNumber.text += "1";
    }

    public void OnClickTwoBtn()
    {
        phoneNumber.text += "2";
    }

    public void OnClickThreeBtn()
    {
        phoneNumber.text += "3";
    }

    public void OnClickFourBtn()
    {
        phoneNumber.text += "4";
    }

    public void OnClickFiveBtn()
    {
        phoneNumber.text += "5";
    }

    public void OnClickSixBtn()
    {
        phoneNumber.text += "6";
    }

    public void OnClickSevenBtn()
    {
        phoneNumber.text += "7";
    }

    public void OnClickEightBtn()
    {
        phoneNumber.text += "8";
    }

    public void OnClickNineBtn()
    {
        phoneNumber.text += "9";
    }

    public void OnClickZeroBtn()
    {
        phoneNumber.text += "0";
    }

    public void OnClickDeleteBtn()
    {
        string number = phoneNumber.text;
        if (number.Length > 0)
        {
            phoneNumber.text = number.Substring(0, number.Length - 1);
        }
    }
}