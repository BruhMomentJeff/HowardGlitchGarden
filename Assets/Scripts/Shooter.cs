using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    //Gives us fields to select and drag assets into, to make the code operate properly.
    [SerializeField] GameObject projectile, gun;

   //Fires a projectile/spawns it where instructed by gun's coordinates.
   public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
