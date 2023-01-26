using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public bool gameIsOver = false;
    public TextMeshProUGUI gameOverText;
    public GameObject gameOverScreen;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        Time.timeScale = 1;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackToMenu();
        }
    }

    public void BackToMenu() 
    {
        SceneManager.LoadScene("Menu");
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("Game");
    }


    public void GameOver(int playerNumber)
    {
        if(!gameIsOver)
        {
            gameIsOver = true;
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
            gameOverText.SetText("Player " + playerNumber + " fell off the arena!");
        }
    }
}
