using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Defines our fltSpeed variable's default speed
    [SerializeField] float fltSpeed = 1f;
    [SerializeField] float fltDamage = 50;

    // Moves our Projectile
    void Update()
    {
        transform.Translate(Vector2.right * fltSpeed * Time.deltaTime);
    }//moves our projectile to the right multiplied by the fltSpeed * Time.deltaTime 

    //Trigger collider for other things/things the projectile collides into.
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var Health = otherCollider.GetComponent<Health>();
        //Reducing Health after getting it from the 'other thing' that was collided with
        var Attacker = otherCollider.GetComponent<Attacker>();

        //Determines if the 'other thing' is an Attacker role and also has Health to drain
        if(Attacker && Health)
        {
            //Deals an amount of damage based of fltDamage
            Health.DealDamage(fltDamage);
            Destroy(gameObject);
            //Destroys the game object
        }
        
    }



}
