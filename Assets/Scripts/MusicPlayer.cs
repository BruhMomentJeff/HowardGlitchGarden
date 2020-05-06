using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;


    //Prevents 'this' from being destroyed upon load and keeps playing throughout
    //the entire game.
    void Start()
    {
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }
    //sets volume
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
