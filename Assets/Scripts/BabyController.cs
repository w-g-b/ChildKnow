using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyController : MonoBehaviour
{
    public static BabyController _instance;
    public GameObject babyAnim;
    public Image babyImage;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
    public Text babyText;
    public Toggle stopAndPlayToggle;
    public AudioSource audioSource;
    [HideInInspector] public float firstTime = 13;
    [HideInInspector] public float secondTime = 20;
    [HideInInspector] public float thirdTime = 29;

    private void Awake()
    {
        _instance = this;
    }

    public void Init()
    {
        firstTime = 13;
        secondTime = 20;
        thirdTime = 29;
        babyText.text = "爸爸的精子和妈妈的卵子这两种生命之源结合在一起就生出了你 好小好小的你 在妈妈一个叫子宫的袋子里慢慢长大";
        babyImage.sprite = firstImage;
    }

    public void Update()
    {
        firstTime -= Time.deltaTime;
        secondTime -= Time.deltaTime;
        thirdTime -= Time.deltaTime;
        if (firstTime <= 0)
        {
            babyImage.sprite = secondImage;
            babyText.text = "等你渐渐长大 妈妈的肚子里的袋子对于你来说太小了";
        }

        if (secondTime <= 0)
        {
            babyImage.sprite = thirdImage;
            babyText.text = "这时你就会经过妈妈两腿间的宝宝出生之路来到这个世界";
        }

        if (thirdTime <= 0)
        {
            babyAnim.SetActive(false);
        }
    }
    public void OnClickStopAndPlayBtn()
    {
        if (stopAndPlayToggle.isOn)
        {
            Time.timeScale = 1;
            audioSource.Play();
        }
        else
        {
            Time.timeScale = 0;
            audioSource.Pause();
        }
    }
}