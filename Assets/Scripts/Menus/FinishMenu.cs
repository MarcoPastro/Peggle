using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class FinishMenu : Menu
{
    [SerializeField]
    private TextMeshProUGUI _CountScoreTMP;
    [SerializeField]
    private TextMeshProUGUI _FinalScoreTMP;
    [SerializeField]
    private int _PointsPerBalls=10;
    private int _score;
    private int _ballsleft;
    private int _finalScore;
    private void Start()
    {
        _finalScore = 0;
    }
    public void SetScoreAndBallsLeft(int score,int ballsleft)
    {
        _score=score;
        _ballsleft=ballsleft;
        ChangeScore();
    }
    private void ChangeScore()
    {
        CalculateFinalScore();
        _CountScoreTMP.text = "Score: " + _score + Environment.NewLine + "Balls Left: " + _ballsleft + " * " + _PointsPerBalls;
        _FinalScoreTMP.text = "FinalScore: " + _finalScore;
    }
    private void CalculateFinalScore()
    {
        _finalScore = _score + _ballsleft * _PointsPerBalls;
    }

    public void CloseMenu()
    {
        SetActive(false);
        Time.timeScale = 1;
    }
    public void OnEscPress()
    {
        SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public override void EscPressedCall()
    {
        if (GetActive())
        {
            OnEscPress();//return to the start menu
        }
    }
}
