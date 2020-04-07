using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Amount of Health
    [SerializeField] float fltHealth = 100f;

    //Dealing Damage and how MUCH damage to deal.
    public void DealDamage(float fltDamage)
    {
        //Decrease health on hit/damage dealt
        fltHealth -= fltDamage;
        if (fltHealth <= 0)
        {
            Destroy(gameObject);
        }//Delete the game object.
    }


}
