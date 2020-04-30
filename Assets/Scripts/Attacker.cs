using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{   //Range between minimum to maximum speed
    [Range (0f, 5f)]
    float fltCurrentSpeed = 1f;
    //The current speed in float format ^
    GameObject currentTarget;

    //Exists to make sure everything happens after it.
    private void Awake()
    {   //Activates AttackerSpawned
        FindObjectOfType<LevelController>().AttackerSpawned();
    }

    private void OnDestroy()
    {   //Activates AttackerKilled
        FindObjectOfType<LevelController>().AttackerKilled();
    }

    void Update()
    {
        transform.Translate(Vector2.left * fltCurrentSpeed * Time.deltaTime);
        //Checks to make sure the Attacker isn't endlessly attacking something, even post it's defeat.
        UpdateAnimationState();
    }
    //If target disappears, then stops attacking/IsAttacking false
    private void UpdateAnimationState()
    {
        if(!currentTarget)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
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

    public void StrikeCurrentTarget(float fltdamage)
    {//Detects if there's no target presence, it stops/ceases attacking.
        if(!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if(health)
        {
            health.DealDamage(fltdamage);
        }
    }

}
