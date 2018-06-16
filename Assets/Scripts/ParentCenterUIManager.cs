using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParentCenterUIManager : MonoBehaviour
{
    public GameObject accountPanel;
    public GameObject restPanel;
    public GameObject helpPanel;
    public GameObject aboutPanel;
    public Toggle accountToggle;
    public Toggle restToggle;
    public Toggle helpToggle;
    public Toggle aboutToggle;

    public InputField babyName;
    public InputField babyBirthday;
    public InputField fatherPhone;
    public InputField motherPhone;

    public Image helpImage;
    public Sprite questionSprite;
    public Sprite adviceSprite;


    private void Start()
    {
        babyName.text = PlayerPrefs.GetString("babyName");
        babyBirthday.text = PlayerPrefs.GetString("babyBirthday");
        fatherPhone.text = PlayerPrefs.GetString("fatherPhone");
        motherPhone.text = PlayerPrefs.GetString("motherPhone");
    }

    public void OnClickSaveBtn()
    {
        PlayerPrefs.SetString("babyName", babyName.text);
        PlayerPrefs.SetString("babyBirthday", babyBirthday.text);
        PlayerPrefs.SetString("fatherPhone", fatherPhone.text);
        PlayerPrefs.SetString("motherPhone", motherPhone.text);
    }

    public void SetPanelState()
    {
        accountPanel.SetActive(accountToggle.isOn);
        restPanel.SetActive(restToggle.isOn);
        helpPanel.SetActive(helpToggle.isOn);
        aboutPanel.SetActive(aboutToggle.isOn);
    }

    public void OnClickQuestionBtn()
    {
        helpImage.sprite = questionSprite;
    }

    public void OnClickAdviceBtn()
    {
        helpImage.sprite = adviceSprite;
    }
}