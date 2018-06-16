using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SexContorller : MonoBehaviour
{
    public static SexContorller _instance;
    public GameObject sexAnim;
    public Image sexImage;
    public Sprite firstImage;
    public Sprite secondImage;
    public Text sexText;
    public Toggle stopAndPlayToggle;
    public AudioSource audioSource;
    [HideInInspector] public float firstTime = 19;
    [HideInInspector] public float secondTime = 38;

    private void Awake()
    {
        _instance = this;
    }

    public void Init()
    {
        firstTime = 19;
        secondTime = 38;
        sexText.text = "男孩的小鸡鸡后面还悬着个袋子 这也是很重要的部位 等你到了上中学的年龄 像一个大人了 在那个袋子里一个睾丸的地方会产生很多叫做精子的东西 他们可是人类的生命之源呀";
        sexImage.sprite = firstImage;
    }

    public void Update()
    {
        firstTime -= Time.deltaTime;
        secondTime -= Time.deltaTime;
        if (firstTime <= 0)
        {
            sexImage.sprite = secondImage;
            sexText.text = "女孩儿的肚子也有一个卵巢的袋子 等女孩长大了 那里会产生卵子 同样也是我们的生命之源 这两种生命之源结合在一起就变成小宝宝了";
        }

        if (secondTime <= 0) sexAnim.SetActive(false);
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