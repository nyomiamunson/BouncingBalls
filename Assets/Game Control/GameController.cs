using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;
    public Text gameOverText;

    private int player1Score = 0;
    private int player2Score = 0;
    private bool gameEnded = false;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    public void IncrementPlayer1Score()
    {
        if (!gameEnded)
        {
            player1Score++;
            player1ScoreText.text = "Player 1 Score: " + player1Score;
            CheckGameOver();
        }
    }

    public void IncrementPlayer2Score()
    {
        if (!gameEnded)
        {
            player2Score++;
            player2ScoreText.text = "Player 2 Score: " + player2Score;
            CheckGameOver();
        }
    }

    void CheckGameOver()
    {
        if (player1Score >= 50 || player2Score >= 50)
        {
            gameEnded = true;
            gameOverText.gameObject.SetActive(true);
            // Stop balls or destroy them
            // Add any other end-game logic here
        }
    }
}
