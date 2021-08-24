using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    int coin;
    int highestCoin;

    private void Start()
    {
        highestCoin = PlayerPrefs.GetInt("highestCoin");
    }


    public void ScoreIncrement()
    {
        coin++;
        score.text = "Coin :" + coin;
        if(coin >highestCoin)
        {
            highestCoin = coin;
            Debug.Log("High Score changed");
            PlayerPrefs.SetInt("highestCoin",highestCoin);
        }
    }


}
