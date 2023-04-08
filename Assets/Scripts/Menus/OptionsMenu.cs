using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : Menu
{
    public void OnBackPress()
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
