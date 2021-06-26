using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource[] music;

    void OnEnable(){
        EventManager.PhaseChanged += ChangeSong;
        EventManager.GameEnded+=SplatSounds;
    }

    void OnDisable(){
        EventManager.PhaseChanged -= ChangeSong;
        EventManager.GameEnded-=SplatSounds;
    }

    void ChangeSong(){
        music[0].Stop();
        music[1].Play();
    }

    void SplatSounds(){
        music[2].Play();
        music[3].Play();
    }
}
