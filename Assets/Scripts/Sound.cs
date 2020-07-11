using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{

public string name;

public AudioClip clip;

[Range(0f, 3f)]
public float volume = 1f;

[Range(0f, 3f)]
public float pitch = 1f;
public bool loop;
[HideInInspector]
public AudioSource source;



}
