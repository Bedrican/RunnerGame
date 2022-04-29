using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject FailMenuUI;
    public GameObject MainMenuUI;
    public GameObject LevelAndCoinUI;
    public GameObject FinishUI;
    public GameObject HUD;

    public Text scoreText;
    public Text coinsText;
    public Text levelText;
    public int level=1;
    void Start()
    {
        
        level = PlayerPrefs.GetInt("Level");
        SetLevelText();
        Time.timeScale = 0;
        MainMenuUI.SetActive(true);
        LevelAndCoinUI.SetActive(true);
        FailMenuUI.SetActive(false);
        FinishUI.SetActive(false);
    }

    private void OnEnable()
    {
        Actions.OnGameOver += GameOver;
        Actions.OnGameFinish += GameFinish;
        Actions.SetScoreText += SetScoreText;
        Actions.SetCoinsText += SetCoinsText;
    }

    private void OnDisable()
    {
        Actions.OnGameOver -= GameOver;
        Actions.OnGameFinish -= GameFinish;
        Actions.SetScoreText -= SetScoreText;
        Actions.SetCoinsText -= SetCoinsText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        FailMenuUI.SetActive(true);
    }

    public void GameFinish()
    {
        FinishUI.SetActive(true);
        HUD.SetActive(false);
    }

    public void OnRetryButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnStartButtonPressed()
    {
        Time.timeScale = 1;
        LevelAndCoinUI.SetActive(true);
        HUD.SetActive(true);
        MainMenuUI.SetActive(false);
    }

    public void OnPowerUpButtonPressed()
    {
        Actions.OnPowerUp();
    }

    public void OnContinueButtonPressed()
    {
        level++;
        PlayerPrefs.SetInt("Level",level);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % 2);
    }

    public void SetScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }
    public void SetCoinsText(int coins)
    {
        coinsText.text = coins.ToString();
    }

    public void SetLevelText()
    {
        levelText.text = "LEVEL " + level;
    }
}
