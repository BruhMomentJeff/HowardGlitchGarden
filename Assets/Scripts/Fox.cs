using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        //Determines if what they encounter is an 'Gravestone' type, they're just jump over it with 'JumpTrigger'
        if(otherObject.GetComponent<Gravestone>())
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }

        //Determines else if what they 'hit' is an 'Defender' type, they'll attack, otherwise they won't.
        else if(otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
