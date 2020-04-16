using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{   //sets the cost of stars.
    [SerializeField] int intStarCost = 100;

    //Gets intStarcost to return in DefenderSpawner.
    public int intGetStarCost()
    {
        return intStarCost;
    }


    //Calls over the method from StarDisplay
    public void AddStars(int intAmount)
    {
        FindObjectOfType<StarDisplay>().AddStars(intAmount);
    }

}
