using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreAndBallsLeft : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _ScoreTMP;
    private int _score;
    [SerializeField]
    private TextMeshProUGUI _BallsTMP;
    private int _ballsLeft;

    public void ChangeTMP(int score, int ballsleft)
    {
        SetScore(score);
        SetBallsLeft(ballsleft);
        _ScoreTMP.text = "Score: " + _score;
        _BallsTMP.text = "Balls Left: " + _ballsLeft;
    }

    public void SetScore(int s)
    {
        _score = s;
    }
    public void SetBallsLeft(int b)
    {
        _ballsLeft = b;
    }
}
