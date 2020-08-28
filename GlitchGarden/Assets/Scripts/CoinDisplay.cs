﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    [SerializeField] int coins = 100; // This is the samething as stars in the tutorial
    Text coinText;
    void Start()
    {
        coinText = GetComponent<Text>();
        UpdateDisplay();
        
    }

    private void UpdateDisplay()
    {
        coinText.text = coins.ToString();
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateDisplay();
    }

    public void SpendCoin (int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
            UpdateDisplay();
        }

    }
}
