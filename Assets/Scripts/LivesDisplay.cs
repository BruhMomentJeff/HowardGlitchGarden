using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int intLives = 5;
    [SerializeField] int intDamage = 1;
    Text strLivesText;

     void Start()
    {   //Defines strLivesText as a Text type
        strLivesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {   //Converts anything in intLives to a string type.
        strLivesText.text = intLives.ToString();
    }

    //Takes Life(points) based on amount specified
    public void TakeLife()
    {
        intLives -= intDamage;
        UpdateDisplay();

        //
        if (intLives <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadYouLose();
        }
    }
}
