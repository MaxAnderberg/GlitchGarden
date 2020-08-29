using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int coinCost = 100; // price per defender
    [SerializeField] GameObject coinVFX;


    public void AddCoins(int amount)
    {
        FindObjectOfType<CoinDisplay>().AddCoins(amount);
        GameObject coinFlash = Instantiate(coinVFX, transform.position, transform.rotation) as GameObject;
        coinFlash.SetActive(false);
        Destroy(coinFlash, 1f);
    }

    public int GetStarCost()
    {
        return coinCost;
    }
}

