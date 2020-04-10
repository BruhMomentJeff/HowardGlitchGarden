using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{   //Allows us to use any defender we drag into this field for spawning.
    [SerializeField] GameObject defender;

    //detects when mouse has been clicked and will 'SpawnDefender'
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }//calls GetSquaredClicked to gather the position for the spawned defender when mouse is clicked

    //Determines where the user clicked inside the collision box provided.
    private Vector2 GetSquareClicked()
    {   //defines the position of a clicking mouse.
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        //Translate clickPos to ScreenToWorldPoint
        return worldPos;
        //Returns worldPos to the Vector2 of 'GetSquareClicked()'
    }


    //On click will spawn Cactus
    private void SpawnDefender(Vector2 worldPos)
    {
        GameObject newDefender = Instantiate(defender, worldPos, Quaternion.identity) as GameObject;
    }

}
