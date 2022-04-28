using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score=0;
    public int coins=0;
    

    private void Awake()
    {
        coins = PlayerPrefs.GetInt("coins");
        
    }

    private void OnEnable()
    {
        Actions.OnScoreNeed += AddScore;
    }

    private void OnDisable()
    {
        Actions.OnScoreNeed -= AddScore;
    }

    public void AddScore(float scoreAmount)
    {
        score += (int)scoreAmount;
        Actions.SetScoreText(score);
        AddCoins(score);
        
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        //PlayerPrefs.SetInt("Coins" , coins);
        Actions.SetCoinsText(coins);
       
    }
}
