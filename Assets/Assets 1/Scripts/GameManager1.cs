using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
  
    public static Vector2 bottomLeft;
    public GameObject gameOverPanel, scoreObject;

    //game states
    public static bool gameOver;
    public static bool gameHasStarted;
    public static bool gameIsPaused;

    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }

    private void Start()
    {
        gameOver = false;
        gameHasStarted = false;
        gameIsPaused = false;
    }

  public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        scoreObject.SetActive(false);
    }

    public void OnOKButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

