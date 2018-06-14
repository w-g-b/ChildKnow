using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public PageName pageName;

    public void OnClickBackBtn()
    {
        if (pageName != null)
        {
            PageController.GoTo(pageName);
        }
    }
}