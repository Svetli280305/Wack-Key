using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public int score;
    public int pointsPerMole = 1;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddPoints()
    {
        score += pointsPerMole;
        UpdateScoreDisplay();
        Debug.Log(score);
    }

    public void UpdateScoreDisplay()
    {
        scoreText.text = $"Score: {score}";
    }
}
