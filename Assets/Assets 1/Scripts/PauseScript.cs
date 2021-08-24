using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour
{

    Image img;
    public Sprite playSprite,pausedSprite;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    public void OnGamePaused()
    {
        if(GameManager1.gameIsPaused==false)
        {
            Time.timeScale = 0;
            img.sprite = playSprite;
            GameManager1.gameIsPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            img.sprite = pausedSprite;
            GameManager1.gameIsPaused = false;
        }
    }
}
