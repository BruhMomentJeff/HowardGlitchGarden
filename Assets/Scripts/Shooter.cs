using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    //Gives us fields to select and drag assets into, to make the code operate properly.
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }

    //Checks for Attackers in the same lane and prompts messages in the console, if or if not.
    private void Update()
    {
        if(IsAttackerInLane())
        {
            Debug.Log("Target Found");
        }
        else
        {
            Debug.Log("No one is there..");
        }
    }
    //Useful for finding all our spawners based on their AttackerSpawner scripts and puts them into an array.
    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {//Subtracts the spawners transform.position.y by the current transform.position.y
            bool boolIsCloseEnough = 
                (Mathf.Abs (spawner.transform.position.y - transform.position.y)
                <= Mathf.Epsilon);
            if(boolIsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {//Checks if Attackers are in lane, if not, returns false thus not attacking 
        //If there IS attackers however, returns true, thus attacking in this case.
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

   //Fires a projectile/spawns it where instructed by gun's coordinates.
   public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
