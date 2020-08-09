using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinEditor : MonoBehaviour
{
    public int coins;
    public Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt("coins", 0);
        coinText.text = "COINS: " + coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "COINS: " + coins.ToString();
    }

    public void IncrementCoins()
    {
        coins++;
        PlayerPrefs.SetInt("coins", coins);
    }
}
