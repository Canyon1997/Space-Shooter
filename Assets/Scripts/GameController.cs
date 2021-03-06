﻿using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text gameOverText;
    public Text restartText;
    public Text winText;
    public Text livesText;



    





    public Text ScoreText;
    public static int score;
    public static int lives;



    private bool gameOver;
    private bool restart;
    








    void Start()
    {
        StartCoroutine(SpawnWaves());
        gameOver = false;
        restart = false;
        gameOverText.text = "";
        restartText.text = "";
        winText.text = "";
        lives = 3;
        score = 0;
        UpdateScore();
        





    }

    void Update()
    {
        livesText.text = "Lives: " + lives;

        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                SceneManager.LoadScene("Space Shooter");
            }

        }

        if (score >= 100)
        {
            winText.text = "You win! Game created by Canyon Davidson";
            gameOver = true;
            restart = true;
            

        }

        if(lives <= 0)
        {
            gameOver = true;
            restart = true;
        }

        if (Input.GetKey("escape"))
            Application.Quit();

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'J' for Restart";
                restart = true;
                break;
            }

        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        ScoreText.text = "Points: " + score;
    }

    

    public void GameOver()
    {
            gameOverText.text = "Game Over!";
            gameOver = true;  
    }

   
}