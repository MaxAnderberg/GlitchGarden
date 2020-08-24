using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 5f;
    [SerializeField] int projectileDamage = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D othercollider)
    {
        var health = othercollider.GetComponent<Health>();
        health.DealDamage(projectileDamage);
    }

}
