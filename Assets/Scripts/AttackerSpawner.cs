using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{   //Minimum Delay before spawning
    [SerializeField] float fltminSpawnDelay = 1f;
    //Maximum Delay before spawning
    [SerializeField] float fltmaxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabArray;

    bool boolSpawn = true;

    IEnumerator Start()
    {//Cooldown before spawning Attacker
        while(boolSpawn)
        {
            yield return new WaitForSeconds(Random.Range(fltminSpawnDelay, fltmaxSpawnDelay));
            SpawnAttacker();
        }//Makes the delay for spawning randomized with the range from the Minimum and Maximum delay.
    }
    
    public void StopSpawning()
    {
        boolSpawn = false;
    }
    
    //Spawn Attacker
    private void SpawnAttacker()
    {
        var attackerIndex = UnityEngine.Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }

    //Detects what to spawn
    private void Spawn (Attacker myAttacker)
    {
        //Clarifies the type being spawned
        Attacker newAttacker = Instantiate
            (myAttacker, transform.position, transform.rotation)
            as Attacker;
        //Clarifies it's X,Y, and even Z axis
        newAttacker.transform.parent = transform;
    }
}
