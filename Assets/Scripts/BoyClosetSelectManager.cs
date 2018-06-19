using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoyClosetSelectManager : MonoBehaviour
{
    public Toggle hairToggle;
    public Toggle clothToggle;
    public GameObject hairPanel;
    public GameObject clothPanel;

    public void SetPanel()
    {
        hairPanel.SetActive(hairToggle.isOn);
        clothPanel.SetActive(clothToggle.isOn);
    }
}