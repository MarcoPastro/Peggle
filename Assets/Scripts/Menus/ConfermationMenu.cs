using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfermationMenu : Menu
{
    public void OnYesPress()
    {
       // Application.Quit();
    }
    public void OnNoPress()
    {
        SetActive(false);
    }
    public override void EscPressedCall()
    {
        if (GetActive())
        {
            SetActive(false);
        }
    }
}
