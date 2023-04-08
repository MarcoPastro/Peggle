using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Menu : MonoBehaviour
{
    private bool _isActive;

    public virtual void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
        _isActive = isActive;
    }

    public virtual bool GetActive()
    {
        return _isActive;
    }
    public abstract void EscPressedCall();
}
