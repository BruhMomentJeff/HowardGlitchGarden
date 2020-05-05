using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //Time to wait
    [SerializeField] int intTimeToWait = 4;
    int intCurrentSceneIndex;

    // Start
    void Start()
    {
        intCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (intCurrentSceneIndex == 0)
        {//If
            StartCoroutine(WaitForTime());
        }//Indicates the current scene.
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(intTimeToWait);
        LoadNextScene();
    } //Loads the Next Scene after waiting intTimeToWait amount of seconds.

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(intCurrentSceneIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene("Options Screen");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(intCurrentSceneIndex + 1);
    }//Load Next Scene

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}