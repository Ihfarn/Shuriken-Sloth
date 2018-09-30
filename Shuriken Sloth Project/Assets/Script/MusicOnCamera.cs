using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnCamera : MonoBehaviour {

    public AudioClip bgmMusic;
      
    private void Awake()
    {
        BGM.instance.PlayBGM(bgmMusic);
    }
}
