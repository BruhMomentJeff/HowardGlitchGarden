using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float fltBaseLives = 3;
    [SerializeField] int intDamage = 1;
    float fltLives;
    Text strLivesText;

     void Start()
    {
        fltLives = fltBaseLives - PlayerPrefsController.GetDifficulty(); 
        //Defines strLivesText as a Text type
        strLivesText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("difficulty setting is currently " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {   //Converts anything in intLives to a string type.
        strLivesText.text = fltLives.ToString();
    }

    //Takes Life(points) based on amount specified
    public void TakeLife()
    {
        fltLives -= intDamage;
        UpdateDisplay();

        //Makes it possible to lose.
        if (fltLives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
