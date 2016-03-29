using UnityEngine;
using System.Collections;

public class AudioEvent : MonoBehaviour {

    void PlayAudio(AudioClip aud) {
        GetComponent<AudioSource>().clip = aud;
        GetComponent<AudioSource>().Play();
    }

    void StopAudio() {
        
        GetComponent<AudioSource>().Stop();
    }
}
