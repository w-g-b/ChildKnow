using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ShowerUIManager : MonoBehaviour
{
    public Animator childAnimator;

    private bool isWater = false;

    private void Awake()
    {
        if (PlayerPrefs.GetString("isWater", "false").Equals("true")) childAnimator.SetBool("isWater", true);

        if (PlayerPrefs.GetString("isBubble", "false").Equals("true")) childAnimator.SetBool("isBubble", true);
    }

    public void OnClickShowerHeadBtn()
    {
        if (isWater == true)
        {
            childAnimator.SetBool("isBubble", false);
            childAnimator.SetBool("isWater", false);
            PlayerPrefs.SetString("isBubble", "false");
            PlayerPrefs.SetString("isWater", "false");
            isWater = false;
        }
        else
        {
            childAnimator.SetBool("isBubble", false);
            childAnimator.SetBool("isWater", true);
            PlayerPrefs.SetString("isBubble", "false");
            PlayerPrefs.SetString("isWater", "true");
            isWater = true;
        }
    }

    public void OnClickShowerGelBtn()
    {
        childAnimator.SetBool("isBubble", true);
        childAnimator.SetBool("isWater", false);
        PlayerPrefs.SetString("isBubble", "true");
        PlayerPrefs.SetString("isWater", "false");
        isWater = false;
    }
}