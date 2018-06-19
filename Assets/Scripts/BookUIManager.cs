using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUIManager : MonoBehaviour
{
    public GameObject sexAnim;

    public GameObject babyAnim;

    public AudioSource audioSource;

    public void OnClickSexBtn()
    {
        audioSource.Stop();
        sexAnim.SetActive(true);
        SexContorller._instance.Init();
    }

    public void OnClickBabyAnim()
    {
        audioSource.Stop();
        babyAnim.SetActive(true);
        BabyController._instance.Init();
    }
}