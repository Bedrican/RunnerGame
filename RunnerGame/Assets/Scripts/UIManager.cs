using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject FailMenuUI;
    public GameObject MainMenuUI;
    public GameObject LevelAndCoinUI;
    void Start()
    {
        Actions.OnGameOver += GameOver;
        MainMenuUI.SetActive(true);
        LevelAndCoinUI.SetActive(true);
        FailMenuUI.SetActive(false);
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

    public void OnRetryButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
