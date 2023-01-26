using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI gameOverText;

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
        Debug.Log("Penis");
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
        gameOverText.SetText("Player " + playerNumber + " fell off the arena!");
    }
}
