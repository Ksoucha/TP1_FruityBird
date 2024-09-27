using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "SCORE: " + score;
    }
}
