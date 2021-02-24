using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mySoundManager : MonoBehaviour
{
    public AudioSource audioEffects;
    public AudioSource audioMusic;

    public static mySoundManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    public void Play(AudioClip clip)
    {
        audioEffects.clip = clip;
        audioEffects.Play();
    }
    public void musicPlay(AudioClip clip)
    {
        audioMusic.clip = clip;
        audioMusic.Play();
    }


}
