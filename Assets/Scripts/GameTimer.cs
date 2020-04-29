using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{   //When mousing over our SerializeField of fltLevelTime, it will provide the blurb of info..
    //'Our level timer in Seconds'
    [Tooltip("Our level timer in Seconds")]
    //Defines how long the fltLevelTime will be in seconds. 
    [SerializeField] float fltLevelTime = 10;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTime;

        bool boolTimerFinshed = (Time.timeSinceLevelLoad >= fltLevelTime);
        if(boolTimerFinshed)
        {
            Debug.Log("Level Time has expired.");
        }
    }
}
