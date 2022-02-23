using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void SetScore(float score)
    {
        scoreText.text = "Score: " + Mathf.Round(score).ToString();
    }
}
