using UnityEngine;
using System.Collections;
using System;

public class ScoreManager : MonoBehaviour {
    public UnityEngine.UI.Text txt;
    public int score;

    void UpdateScore()
    {
        txt.text = "Score: " + score;
    }

    internal void AddPoint(int adPoint)
    {
        score = score + adPoint;
        UpdateScore();
    }
}
