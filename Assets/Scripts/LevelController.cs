using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    //Helps determine how many attackers are remaining
    int intNumberOfAttackers = 0;
    bool boolLevelTimerFinished = false;

    //Checks for when an attacker is spawned that it counts up any new attackers
    //into intNumberOfAttackers
    public void AttackerSpawned()
    {
        intNumberOfAttackers++;
    }
    //Checks for if all the attackers are 'killed' the level will be over.
    public void AttackerKilled()
    {
        intNumberOfAttackers--;
        if(intNumberOfAttackers <= 0 && boolLevelTimerFinished)
        {
            Debug.Log("Level Over!");
        }
    }
    //Checks for when the Level Timer has Finished and stops spawning attacks.
    public void boollevelTimerFinished()
    {
        boolLevelTimerFinished = true;
        StopSpawners();
    }
    //Stops Spawners
    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
