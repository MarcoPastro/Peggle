using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public ScriptableBlocks MyScriptable;
    private bool _isHit;
    private bool _isActive;
    private bool _isDouble;
    // Start is called before the first frame update
    void Start()
    {
        _isActive=true;
        _isHit = false;
        gameObject.GetComponent<Collider2D>().sharedMaterial = MyScriptable.Material;
        
    }
    public void SetTheBlock(bool isDouble)
    {
        if (!isDouble) 
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = MyScriptable.NormalSprite;
        }
        else
        {
            _isDouble = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = MyScriptable.DoubleSprite;
        }
    }
    public int GetScore()
    {
        if (!_isDouble)
        {
            return MyScriptable.Score;
        }
        else
        {
            return MyScriptable.DoubleScore;
        }
        
    }

    public void Behit()
    {
        if (!_isHit)
        {
            ChangeSpriteInHit();
            _isHit = true;
        }
    }

    public void ChangeSpriteInHit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = MyScriptable.HitSprite;
    }

    public bool GetHit()
    {
        return _isHit;
    }
    public bool GetIsActive()
    {
        return _isActive;
    }
    public void DeactivateStacks()
    {
        gameObject.SetActive(false);
        _isActive = false;
    }
    public void Deactivate()
    {
        gameObject.SetActive(false);
        _isActive = false;
        _isHit = false;
    }
    public void Reactivate()
    {
        _isDouble = false;
        _isActive = true;
        _isHit = false;
        gameObject.SetActive(true);
    }
}
