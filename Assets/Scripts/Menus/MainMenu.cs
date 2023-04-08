using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : Menu
{
    [SerializeField]
    private OptionsMenu _OptionsMenu;
    [SerializeField]
    private ConfermationMenu _ConfermationMenu;
    [SerializeField]
    private LevelMenu _LevelMenu;
    public void OnPlayPress()
    {
        _LevelMenu.SetActive(true);
    }
    public void OnOptionsPress()
    {
        _OptionsMenu.SetActive(true);
    }
    public void OnExitPress()
    {
        _ConfermationMenu.SetActive(true);
    }
    public override void EscPressedCall()
    {
        if (!_OptionsMenu.GetActive() && !_LevelMenu.GetActive() && _ConfermationMenu.GetActive())
        {
            OnExitPress();
        }
    }
}
