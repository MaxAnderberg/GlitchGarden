using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamage : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var player = FindObjectOfType<PlayerHealth>();
       
        if (player.GetPlayerHealth() <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
            //FindObjectOfType<Level>().LoadYouLose();
        } else if (player.GetPlayerHealth() >= 1)
        {
            player.TakeDamage(1);
            Destroy(otherCollider.gameObject, 1f);
        }

    }


}
