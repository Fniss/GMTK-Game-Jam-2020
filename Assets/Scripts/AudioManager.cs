using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
public Sound[] sounds;
    
    void Awake()
    {
    foreach (Sound s in sounds)
    {
    //  Add an audio source for each sound in sounds.
    s.source = gameObject.AddComponent<AudioSource>();
    s.source.clip = s.clip;
    s.source.volume = s.volume;
    s.source.pitch = s.pitch;
    }
    }
    public void Play(string name)
    {
    //  Find the sound that has the same name as the name provided.
    Sound s = Array.Find(sounds, _ => _.name == name);
    //  Play the sound via its source.
    s.source.Play();
    }
}
