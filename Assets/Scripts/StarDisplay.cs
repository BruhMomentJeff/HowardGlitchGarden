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
    
    //Checks if you have enough stars to spend.
    public bool boolHaveEnoughStars(int intAmount)
    {
        return intStars >= intAmount;
    }
    //Adds stars based on amount allotted
    public void AddStars(int intAmount)
    {
        intStars += intAmount;
        UpdateDisplay();
    }
    //Spends stars based on amount specified
    public void SpendStars(int intAmount)
    {
        if (intStars >= intAmount) ;
        {
            intStars -= intAmount;
            UpdateDisplay();
        }
    }

}
