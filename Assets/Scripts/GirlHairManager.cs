using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlHairManager : MonoBehaviour
{
    public Image hair;
    public Sprite hair0;
    public Sprite hair1;
    public Sprite hair2;
    public Toggle toggle1;
    public Toggle toggle2;
    public void OnClick1()
    {
        if (toggle1.isOn)
        {
            hair.sprite = hair1;
        }
        else
        {
            hair.sprite = hair0;
        }
    }

    public void OnClick2()
    {
        if (toggle2.isOn)
        {
            hair.sprite = hair2;
        }
        else
        {
            hair.sprite = hair0;
        }
    }
    
}