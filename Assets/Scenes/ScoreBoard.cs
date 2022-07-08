using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

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

    public void SaveScore()
    {
        List<int> scores = new List<int>();

        for(int i = 0; i < 5; i++)
        {
            scores.Add(PlayerPrefs.GetInt($"score{i}") != null ? PlayerPrefs.GetInt($"score{i}") : 0);
        }
        scores.Add(score);
        scores.Sort((x, y) => x.CompareTo(y));
        for(int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetInt($"score{i}", scores[i]);
        }
        Debug.Log(scores[0]);
    }
}
