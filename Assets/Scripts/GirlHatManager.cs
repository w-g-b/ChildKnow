using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlHatManager : MonoBehaviour
{
    public Image hat;
    public Sprite hat0;
    public Sprite hat1;
    public Toggle toggle1;
    public void OnClick1()
    {
        if (toggle1.isOn)
        {
            hat.sprite = hat1;
        }
        else
        {
            hat.sprite = hat0;
        }
    }
    
    
}