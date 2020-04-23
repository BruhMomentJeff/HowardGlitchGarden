using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{   //Range between minimum to maximum speed
    [Range (0f, 5f)]
    float fltCurrentSpeed = 1f;
    //The current speed in float format
    GameObject currentTarget;

    void Update()
    {
        transform.Translate(Vector2.left * fltCurrentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed (float fltSpeed)
    {
        fltCurrentSpeed = fltSpeed;
    }

    //Sets a true or false to IsAttacking depending on if there's a target in front of them.
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
    }
}
