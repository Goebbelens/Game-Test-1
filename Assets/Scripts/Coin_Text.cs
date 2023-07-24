using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin_Text : MonoBehaviour
{
    private int taken  = 0;
    void Start()
    {
        GlobalEventManager.OnCoinTaken += CoinTaken;
    }

    private void OnDestroy()
    {
        GlobalEventManager.OnCoinTaken -= CoinTaken;
    }

    private void CoinTaken()
    {
        taken++;
        GetComponent<TextMeshProUGUI>().text = "Coins: " + taken.ToString();
    }
}
