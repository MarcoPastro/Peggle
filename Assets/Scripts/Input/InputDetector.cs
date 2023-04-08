using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetector : MonoBehaviour
{
    [SerializeField]
    private Cannon _Cannon;
    [SerializeField]
    private Move _Movement;
    [SerializeField]
    private List<Menu> _Menus;
    private Vector3 _mousePosition;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale>0)
        {
            if (Input.GetMouseButton(1))
            {
                _mousePosition = Input.mousePosition;
                _mousePosition = Camera.main.ScreenToWorldPoint(_mousePosition);
                _Movement.ChangePosition(_mousePosition);
            }
            if (Input.GetMouseButtonDown(0))
            {
                _Cannon.Shot();
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            EscPressedCall();
        }
    }
    private void EscPressedCall()
    {
        foreach (Menu m in _Menus) {
            m.EscPressedCall();
        }
    }
}
