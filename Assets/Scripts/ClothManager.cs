using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothManager : MonoBehaviour
{
    public Image cloth;
    public Sprite cloth0;
    public Sprite cloth1;
    public Sprite cloth2;
    public Sprite cloth3;
    public Sprite cloth4;
    public Sprite cloth5;
    public Sprite cloth6;
    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;
    public Toggle toggle4;
    public Toggle toggle5;
    public Toggle toggle6;

    public void OnClick1()
    {
        if (toggle1.isOn)
        {
            cloth.sprite = cloth1;
        }
        else
        {
            cloth.sprite = cloth0;
        }
    }

    public void OnClick2()
    {
        if (toggle2.isOn)
        {
            cloth.sprite = cloth2;
        }
        else
        {
            cloth.sprite = cloth0;
        }
    }

    public void OnClick3()
    {
        if (toggle3.isOn)
        {
            cloth.sprite = cloth3;
        }
        else
        {
            cloth.sprite = cloth0;
        }
    }

    public void OnClick4()
    {
        if (toggle4.isOn)
        {
            cloth.sprite = cloth4;
        }
        else
        {
            cloth.sprite = cloth0;
        }
    }

    public void OnClick5()
    {
        if (toggle5.isOn)
        {
            cloth.sprite = cloth5;
        }
        else
        {
            cloth.sprite = cloth0;
        }
    }

    public void OnClick6()
    {
        if (toggle6.isOn)
        {
            cloth.sprite = cloth6;
        }
        else
        {
            cloth.sprite = cloth0;
        }
    }
}