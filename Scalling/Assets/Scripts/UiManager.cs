﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiManager : MonoBehaviour
{
    public Button[] buttons;
    public Text scoreText;
    bool gameOver;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("ScoreUpdate", 1f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

    }
    void ScoreUpdate()
    {
        if (gameOver == false)
        {
            score += 1;
        }
    }
    public void gameOverActivated()
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
    public void ToGame()
    {
        SceneManager.LoadScene("Level1");
    }


    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }


    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

