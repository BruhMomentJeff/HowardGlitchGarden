using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{   //Minimum Delay before spawning
    [SerializeField] float fltminSpawnDelay = 1f;
    //Maximum Delay before spawning
    [SerializeField] float fltmaxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;

    bool boolSpawn = true;

    IEnumerator Start()
    {//Cooldown before spawning Attacker
        while(boolSpawn)
        {
            yield return new WaitForSeconds(Random.Range(fltminSpawnDelay, fltmaxSpawnDelay));
            SpawnAttacker();
        }//Makes the delay for spawning randomized with the range from the Minimum and Maximum delay.
    }
    //Spawn Attacker
    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }//Clarifies it's X,Y, and even Z axis

    // Update is called once per frame
    void Update()
    {
        
    }
}
