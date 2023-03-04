using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume = 1f; // корегувати гучність , float - десяткові значення 0.2 , 0.3 ...

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}// компонент для встановлення та корегуання музики
