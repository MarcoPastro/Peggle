using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : Menu
{
    public void OnLvlPress(int levelpressed)
    {
        SceneManager.LoadScene(levelpressed);
    }
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
