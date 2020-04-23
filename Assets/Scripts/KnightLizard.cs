using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightLizard : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        //Determines if what they 'hit' is an 'Defender' type, they'll attack, otherwise they won't.
        if(otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
