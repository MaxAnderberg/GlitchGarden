using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int playerHealth = 10; // One unit does one damage. So on collider -1
    Text playerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        playerHealthText = GetComponent<Text>();
        UpdateDisplay();

    }

    public int GetPlayerHealth()
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
