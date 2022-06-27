using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public float score;
    public float pointsPerMole = 1;
    public Text scoreText;

    public void AddPoints()
    {
        score += pointsPerMole;
                UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
    scoreText.text = "Score: " + score;
    }
}
