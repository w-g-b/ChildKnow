using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothManager : MonoBehaviour
{
    public Image cloth;
    public Sprite cloth1;
    public Sprite cloth2;
    public Sprite cloth3;
    public Sprite cloth4;
    public Sprite cloth5;
    public Sprite cloth6;

    public void OnClick1()
    {
        cloth.sprite = cloth1;
    }
    public void OnClick2()
    {
        cloth.sprite = cloth2;
    }
    public void OnClick3()
    {
        cloth.sprite = cloth3;
    }
    public void OnClick4()
    {
        cloth.sprite = cloth4;
    }
    public void OnClick5()
    {
        cloth.sprite = cloth5;
    }
    public void OnClick6()
    {
        cloth.sprite = cloth6;
    }
}