using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
public Sound[] sounds;
    
    void Start()
    {
    Play("Theme");
    }

    void Awake()
    {
    foreach (Sound s in sounds)
    {
    //  Add an audio source for each sound in sounds.
    s.source = gameObject.AddComponent<AudioSource>();
    s.source.clip = s.clip;
    s.source.volume = s.volume;
    s.source.pitch = s.pitch;
    s.source.loop = s.loop;
    }
    }
    public void Play(string name)
    {
    //  Find the sound that has the same name as the name provided.
    Sound _s = Array.Find(sounds, sound => sound.name == name);
    //  Play the sound via its source.
    if (_s != null)
    _s.source.Play();
    else
    Debug.LogWarning("Sound: " + name + " not found! Please check that it is spelled correctly.");
    }
}
