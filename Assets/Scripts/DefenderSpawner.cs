using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    //detects when mouse has been clicked and will 'SpawnDefender'
    private void OnMouseDown()
    {
        SpawnDefender();
    }

    //On click will spawn Cactus
    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(defender, transform.position, Quaternion.identity) as GameObject;
    }

}
