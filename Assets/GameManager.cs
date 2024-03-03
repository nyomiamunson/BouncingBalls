using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;
    public Text gameOverText;

    private int player1Score = 0;
    private int player2Score = 0;
    private bool gameOver = false;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        if (!gameOver)
        {
            // Logic to update scores and check for game end
        }
    }

    void UpdateScoreText()
    {
        player1ScoreText.text = "Player 1 Score: " + player1Score;
        player2ScoreText.text = "Player 2 Score: " + player2Score;
    }

    void EndGame()
    {
        gameOver = true;
        // Stop the movement of balls or destroy them
        // Display "Game Over" message
        gameOverText.text = "Game Over";
    }

    // Collision detection code goes here, increment scores accordingly

}