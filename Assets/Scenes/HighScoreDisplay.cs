using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        DisplayHighScore();
    }

    public void DisplayHighScore()
    {
        string text = "";
        for (int i = 0; i < 5; i++)
        {
            text += $"{i+1} - {string.Format("{0:000000}", PlayerPrefs.GetInt($"score{i}") != null ? PlayerPrefs.GetInt($"score{i}") : 0)}\n";
        }
        scoreText.text = text;
    }
    public void HideEntryDisplay()
    {
        scoreText.text = "";
    }
}
