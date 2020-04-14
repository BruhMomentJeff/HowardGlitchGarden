using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{   
    Defender defender;

    //detects when mouse has been clicked and will 'SpawnDefender'
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }//calls GetSquaredClicked to gather the position for the spawned defender when mouse is clicked

    //Whatever gets passed in is now assigned to defenderToSelect.
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }


    //Determines where the user clicked inside the collision box provided.
    private Vector2 GetSquareClicked()
    {   //defines the position of a clicking mouse.
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //Translate clickPos to ScreenToWorldPoint
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        //Convers worldPos to gridPos
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
        //Returns gridPos to the Vector2 of 'GetSquareClicked()'
    }

    //Helps convert decimals to integers.
    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        //Rounds X and Y position of rawWorldPos to integers
        float fltNewX = Mathf.RoundToInt(rawWorldPos.x);
        float fltNewY = Mathf.RoundToInt(rawWorldPos.y);
        //Returns fltNewX and fltNewY.
        return new Vector2(fltNewX, fltNewY);

    }


    //On click will spawn Cactus
    private void SpawnDefender(Vector2 roundedPos)
    {
        Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
        Debug.Log(roundedPos);
    }

}
