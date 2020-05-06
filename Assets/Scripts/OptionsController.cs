using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.8f;

    //Is utilizing the slider for volume and it's value.
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    }

    //Allows easy access of Music Player
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer) //For if the musicPlayer is already in use.
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else //Will occur if you don't start from the splash screen.
        {
            Debug.LogWarning("No music player found, did you start from the splash screen?");
        }
    }
    //Saves your settings when you Exit options screen.
    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }
    //Upon selecting Defaults, it will revert the slider back to the defaultVolume.
    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
    }
}
