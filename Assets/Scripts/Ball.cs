using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Ball : MonoBehaviour
{
    private Block _block;
    [SerializeField]
    private float _TimerBeforDeleteBlock=10;
    private float _countTimer;
    private bool _isColliding;
    private void Start()
    {
        _countTimer = 0;
        _isColliding = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _block = collision.gameObject.GetComponent<Block>();
        if (_block)
        {
            _block.Behit();
            _isColliding = true;
        }
        //_countFrame = 0;
        
    }
    //after n calls it does't work
    /*private void OnCollisionStay2D(Collision2D collision)
    {
        _countFrame++;
        if (_countFrame > _FramesBeforeDeleteTheBlock)
        {
            _block.Deactivate();
        }
    }*/
    private void OnCollisionExit2D(Collision2D collision)
    {
        _isColliding = false;
        _countTimer = 0;
    }
    private void CheckIfStack()
    {
        if (_countTimer > _TimerBeforDeleteBlock)
        {
            if (_block)
            {
                _block.DeactivateStacks();
            }
        }
    }
    void Update()
    {
        if (_isColliding)
        {
            _countTimer += Time.deltaTime;
            CheckIfStack();
        }
    }
}
