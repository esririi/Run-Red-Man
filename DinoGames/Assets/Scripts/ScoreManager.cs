using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{


    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    public Player player;

    private void Start()
    {
        player.score = 0;
        highScoreText.text = "High Score: " + player.highScore;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ScoreCounter")
        {
            Debug.Log("Skorladým.");
            player.score++;
            scoreText.text = "Score: " + player.score;
            if (player.highScore< player.score)
            {
                player.highScore = player.score;
                highScoreText.text = "High Score: " + player.highScore;
            }
            
        }
    }
}
