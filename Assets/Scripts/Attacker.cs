using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{   //Range between minimum to maximum speed
    [Range (0f, 5f)]
    float fltCurrentSpeed = 1f;
    //The current speed in float format
    void Update()
    {
        transform.Translate(Vector2.left * fltCurrentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed (float fltSpeed)
    {
        fltCurrentSpeed = fltSpeed;
    }

}
