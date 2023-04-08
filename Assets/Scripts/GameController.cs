using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private ScoreAndBallsLeft _ScoreAndBallsLeft;
    [SerializeField]
    private List<Block> _Blocks;
    [SerializeField]
    private FinishMenu _FinishMenu;
    [SerializeField]
    private int _BallsNumber = 3;
    private int _ballsNumberCount;
    [SerializeField]
    private int _DoubleScoreBlocksNumber=0;
    private int _doubleScoreBlocksCounter;
    private int _score;
    private int _hitBlocksNumber;
    private System.Random rnd;
    // Start is called before the first frame update
    void Start()
    {
        rnd=new System.Random();
        _ballsNumberCount = _BallsNumber;
        _score = 0;
        _hitBlocksNumber = 0;
        _doubleScoreBlocksCounter = _DoubleScoreBlocksNumber;
        _ScoreAndBallsLeft.ChangeTMP(_score, _BallsNumber);
        SetBlocks();
    }
    private void SetBlocks()
    {
        _doubleScoreBlocksCounter = _DoubleScoreBlocksNumber;
        foreach (Block b in _Blocks.OrderBy(item => rnd.Next()))
        {

            if (_doubleScoreBlocksCounter <= 0)
            {
                b.SetTheBlock(false);
            }
            else
            {
                b.SetTheBlock(true);
                _doubleScoreBlocksCounter--;
            }
        }
    }
    public void DeleteHit()
    {
        _ballsNumberCount--;
        
        foreach (Block b in _Blocks)
        {
            if (b.GetHit())
            {
                _hitBlocksNumber++;
                _score = _score + b.GetScore();
                b.Deactivate();
            }
        }
        _ScoreAndBallsLeft.ChangeTMP(_score, _ballsNumberCount);
        if (_ballsNumberCount == 0 || _hitBlocksNumber == _Blocks.Count)
        {
            Finish();
        }
    }
    
    public void Finish()
    {
        _FinishMenu.SetScoreAndBallsLeft(_score, _ballsNumberCount);
        _FinishMenu.SetActive(true);
       
        Time.timeScale = 0;
    }

    public void Replay()
    {
        _ballsNumberCount = _BallsNumber;
        _score = 0;
        _hitBlocksNumber = 0;
        _doubleScoreBlocksCounter = _DoubleScoreBlocksNumber;
        _ScoreAndBallsLeft.ChangeTMP(_score, _BallsNumber);
        ReactivateBlocks();
        SetBlocks();
        _FinishMenu.CloseMenu();
        
    }
    private void ReactivateBlocks()
    {
        foreach (Block b in _Blocks)
        {
            b.Reactivate();
        }
    }
}
