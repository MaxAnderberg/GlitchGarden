﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    Defender defender;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       


    }

    private void OnMouseDown()
    {
        {
            AttemptToPlaceDefenderAt(GetSquareClicked());
        }
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var coinDisplay = FindObjectOfType<CoinDisplay>();
        int defenderCost = defender.GetStarCost();
        // if we have enough cash to spend we can spend the cash!
        if(coinDisplay.HaveEnoughCoins(defenderCost))
        {
            SpawnDefenders(gridPos);
            coinDisplay.SpendCoin(defenderCost);
        }

    }

    private Vector2 GetSquareClicked()
    {
            Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
            Vector2 gridPos = SnapToGrid(worldPos);
            return gridPos;
    }
    
    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefenders(Vector2 roundedPos)
    {
            Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
    }
  

}	
