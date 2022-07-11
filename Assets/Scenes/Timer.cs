using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 90.0f;
    public TextMeshProUGUI timerText;

    void Update()
    {
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            ScoreBoard sb = FindObjectOfType<ScoreBoard>();
            Debug.Log(sb);
            sb.SaveScore();
        }
        timerText.text = $"{Mathf.Round(timer)}";
    }
}
