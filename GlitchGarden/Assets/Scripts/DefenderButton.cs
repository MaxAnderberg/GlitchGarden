using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;


    private void OnMouseDown()
    {
        Debug.Log("Clicking the right area you are!");
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(85, 85, 85,255); // 85 85 85 
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<SpawnDefender>().SetSelectedDefender(defenderPrefab);

    }
}
