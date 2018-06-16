using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosetSelectManager : MonoBehaviour
{
    public Toggle hairToggle;
    public Toggle hatToggle;
    public Toggle clothToggle;
    public GameObject hairPanel;
    public GameObject hatPanel;
    public GameObject clothPanel;

    public void SetPanel()
    {
        hairPanel.SetActive(hairToggle.isOn);
        hatPanel.SetActive(hatToggle.isOn);
        clothPanel.SetActive(clothToggle.isOn);
    }
}