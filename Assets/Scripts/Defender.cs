using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{   //sets the cost of stars.
    [SerializeField] int intStarCost = 100;

    //Calls over the method from StarDisplay
    public void AddStars(int intAmount)
    {
        FindObjectOfType<StarDisplay>().AddStars(intAmount);
    }

}
