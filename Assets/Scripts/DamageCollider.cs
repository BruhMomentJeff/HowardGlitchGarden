using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    //Upon contact with Trigger, activates TakeLife, 
    //reducing the amount of Life(points) left by 1.
    private void OnTriggerEnter2D()
    {
        FindObjectOfType<LivesDisplay>().TakeLife();
    }
}
