using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUIManager : MonoBehaviour
{
    public GameObject sexAnim;

    public GameObject babyAnim;

    public void OnClickSexBtn()
    {
        sexAnim.SetActive(true);
        SexContorller._instance.Init();
    }

    public void OnClickBabyAnim()
    {
        babyAnim.SetActive(true);
        BabyController._instance.Init();
    }
}