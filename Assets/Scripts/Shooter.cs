using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    //Gives us fields to select and drag assets into, to make the code operate properly.
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;
    GameObject projectileParent;
    const string PROJECTILE_PARENT_NAME = "Projectiles";

    private void Start()
    {
        SetLaneSpawner();
        //Gets the animator component
        animator = GetComponent<Animator>();
        //Creates the parent of Projectiles
        CreateProjectileParent();
    }

    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    //Checks for Attackers in the same lane and changes the 'isAttacking' statement made in the animator, with true or false.
    private void Update()
    {
        if(IsAttackerInLane())
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
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
        GameObject newProjectile =
            Instantiate(projectile, gun.transform.position, transform.rotation)
            as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
    }
}
