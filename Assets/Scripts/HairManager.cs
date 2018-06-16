using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HairManager : MonoBehaviour
{
    public Image hair;
    public Sprite hair1;
    public Sprite hair2;
    public Sprite hair3;
    public Sprite hair4;

    public void OnClick1()
    {
        hair.sprite = hair1;
    }

    public void OnClick2()
    {
        hair.sprite = hair2;
    }

    public void OnClick3()
    {
        hair.sprite = hair3;
    }

    public void OnClick4()
    {
        hair.sprite = hair4;
    }
}