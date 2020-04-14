using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    //Displays the amount of stars the player will have.
    [SerializeField] int intStars = 100;
    Text strStarText;

    void Start()
    {   //Defines strStarText as a .text
        strStarText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {   //Converts anything in intStars to a string type.
        strStarText.text = intStars.ToString();
    }
    
    public void AddStars(int intAmount)
    {
        intStars += intAmount;
        UpdateDisplay();
    }

    public void SpendStars(int intAmount)
    {
        if (intStars >= intAmount) ;
        {
            intStars -= intAmount;
            UpdateDisplay();
        }
    }

}
