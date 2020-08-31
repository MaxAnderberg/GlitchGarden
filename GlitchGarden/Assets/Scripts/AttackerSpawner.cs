using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float maxSpawnDelay = 1f;
    [SerializeField] float minSpawnDelay = 5f;
    [SerializeField] List<Attacker> attackerPrefab; // make this an Array
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
        //StartCoroutine(Spawn());
    }

    private void SpawnAttacker()
    {
        var randomAttackerIndex = Random.Range(0, attackerPrefab.Count  );
        var attacker = attackerPrefab[randomAttackerIndex];
        Spawn(attacker);
    }

    private void Spawn(Attacker attacker)
    {
        Attacker newAttacker = Instantiate(attacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
