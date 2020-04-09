using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Amount of Health
    [SerializeField] float fltHealth = 100f;
    [SerializeField] GameObject deathVFX;

    //Dealing Damage and how MUCH damage to deal.
    public void DealDamage(float fltDamage)
    {
        //Decrease health on hit/damage dealt
        fltHealth -= fltDamage;
        if (fltHealth <= 0)
        {
            //Upon death will trigger a VFX effect
            TriggerDeathVFX();
            Destroy(gameObject);
            //Deletes the game object.
        }
    }
    //Makes it so that the Death VFX Effect is not destroyed along with the game object
    private void TriggerDeathVFX()
    {
        if(!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        //Spawns deathVFX where instructed by the dead enemy's position and rotation (x,y,or z axis)
        Destroy(deathVFXObject, 1f);
        //Destroys the VFX effect object after 1 second [in this case but it can be modified]
    }
}
