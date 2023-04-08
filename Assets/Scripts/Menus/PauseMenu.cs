using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : Menu
{
    [SerializeField]
    private OptionsMenu _OptionsMenu;
    [SerializeField]
    private FinishMenu _FinishMenu;
    public void OnResumePress()
    {
        Time.timeScale = 1;
        SetActive(false);
    }
    public void OnOptionsPress()
    {
        _OptionsMenu.SetActive(true);
    }
    public void OnExitPress()
    {
        SetActive(false);
        SceneManager.LoadScene("GameMenu");
        Time.timeScale = 1;
    }
    public override void EscPressedCall()
    {
        if (GetActive()) {
            if (_OptionsMenu.GetActive())
            {
                _OptionsMenu.SetActive(false);
            }
            else
            {
                SetActive(false);
                Time.timeScale = 1;
            }
        }
        else
        {
            if (!_FinishMenu.GetActive())
            {
                SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
