using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    //Helps you select a specific prefab
    [SerializeField] Defender defenderPrefab;


    private void OnMouseDown()
    {   //Tries to find DefenderButton using the variable buttons
        var buttons = FindObjectsOfType<DefenderButton>();
        //Looks for button within buttons
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        //Upon clicking we'll be able to turn our buttons for defenders back to white color.
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
        //when passed, it will know what to call now.
    }






}
