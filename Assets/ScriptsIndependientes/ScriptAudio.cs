using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAudio : MonoBehaviour
{

    AudioSource _audioSource;
    public static ScriptAudio inst;

    void Awake(){
        if(ScriptAudio.inst == null){
            ScriptAudio.inst = this;
            DontDestroyOnLoad(gameObject);
            _audioSource = GetComponent<AudioSource>();
        }else{
            Destroy(gameObject);
        }
    }

    public static void Pausar(){
        inst._audioSource.Pause();
    }

    public static void Despause(){
        inst._audioSource.UnPause();
    }
}