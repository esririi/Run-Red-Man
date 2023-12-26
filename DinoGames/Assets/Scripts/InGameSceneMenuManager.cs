using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InGameSceneMenuManager : MonoBehaviour
{
    public static InGameSceneMenuManager Instance;
    public GameObject inGameScreen;
    public GameObject pauseScreen;
    public GameObject gameOverScreen;
    public TMP_Text highScoreText;
    public TMP_Text scoreText;
    public Player player;


    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PauseButton()
    {
        Time.timeScale = 0;
        inGameScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }
    

    public void PlayButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        inGameScreen.SetActive(true);
    }


    public void RePlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }


    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }


    public void Dead()
    {
        highScoreText.text = "High Score: " + player.highScore;
        scoreText.text = "Score: " + player.score;
        Time.timeScale = 0;
        inGameScreen.SetActive(false);
        gameOverScreen.SetActive(true);

    }
}
