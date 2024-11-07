using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;               // Current score
    public Text scoreText;              // UI Text to display the score
    public AudioSource winner;
    public GameObject winnerbox;
    // Method to increase the score
    public void IncreaseScore()
    {
        score++;
        UpdateScoreUI();
    }

    // Update the UI text to display the current score
    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString() + " / 14";
        }
    }

    public void Update()
    {
        if (score >= 10) 
        {


            Winner();

            return;
        }
    }
    public void Winner() 
    {
    winner.Play();
    
    }
}