﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackListener : MonoBehaviour
{
    float doubleClickStart = 0;

    float doubleClickTime = 2; //间隔两秒

    void Update()
    {
        OnDoubleClickQuit();
    }

    private void OnDoubleClickQuit()

    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if ((Time.time - doubleClickStart) > doubleClickTime) //
            {
                doubleClickStart = Time.time;

                AndroidUtil.Toast("再次点击将退出应用");
            }
            else
            {
                if (Time.time > doubleClickStart)
                {
                    Application.Quit();
                }
            }
        }
    }
}