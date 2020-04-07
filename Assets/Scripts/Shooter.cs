using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    //Instantiates the projectile
    [SerializeField] GameObject projectile, gun;

   //Fires a projectile
   public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
