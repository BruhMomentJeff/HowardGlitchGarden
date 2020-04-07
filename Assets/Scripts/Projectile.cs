using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Defines our fltSpeed variable's default speed
    [SerializeField] float fltSpeed = 1f;

    // Moves our Projectile
    void Update()
    {
        transform.Translate(Vector2.right * fltSpeed * Time.deltaTime);
    }//moves our projectile to the right multiplied by the fltSpeed * Time.deltaTime 
}
