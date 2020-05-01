using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float fltWaitToLoad = 4f;
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    //Helps determine how many attackers are remaining
    int intNumberOfAttackers = 0;
    bool boolLevelTimerFinished = false;

    //Turns off Labels at the start.
    private void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

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
            StartCoroutine(HandleWinCondition());
        }
    }
    //Activates WinLabel by setting it to true.
    //Plays the audio source after waiting 'for seconds'
    //And then LoadsNextScene
    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(fltWaitToLoad);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    //Activates loseLabel by setting it to true.
    public void HandleLoseCondition()
    {
        loseLabel.SetActive(true);
        Time.timeScale = 0;

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
