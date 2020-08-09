using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void play()
    {
        sound.Play();
    }

}
