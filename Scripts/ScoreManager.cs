using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public int currentScore;
    public TextMeshProUGUI scoreLabel;

    public void IncreaseScore(int amount)
    {
        currentScore += amount;
        UpdateText();
    }

    public void UpdateText()
    {
        scoreLabel.text = "Score: " + currentScore.ToString();
    }
}
