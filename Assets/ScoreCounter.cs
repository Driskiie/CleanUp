using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public ScoreManager scoreManager;
    
    private void OnEnable()
    {
        if (scoreManager != null)
        {
            scoreManager.IncreaseScore();
        }
    }

}
