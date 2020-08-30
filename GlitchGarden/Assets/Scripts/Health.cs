using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    float deathTime = 1f;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0 )
        {
            //DeathVFX();
            Destroy(gameObject);
        }
    }

    private void DeathVFX()
    {
        GameObject death = Instantiate(deathVFX, transform.position, transform.rotation) as GameObject;
        Destroy(death, 1f);

    }

}
