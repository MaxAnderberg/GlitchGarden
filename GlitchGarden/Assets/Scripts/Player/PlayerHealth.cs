using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float baseHealth = 3;
    
    
    float playerHealth; // 
    Text playerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = baseHealth - PlayerPrefsController.GetDifficulty();
        playerHealthText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("The diffuculty is: " + PlayerPrefsController.GetDifficulty());

    }

    public float  GetPlayerHealth()
    {
        return playerHealth;
    }
    // remember to set this to on trigger in Unity

    private void UpdateDisplay()
    {
        playerHealthText.text = playerHealth.ToString();
    }

    public void TakeDamage(int amount)
    {
        if (playerHealth >= amount)
        {
            playerHealth -= amount;
            UpdateDisplay();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
