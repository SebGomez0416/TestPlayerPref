using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{ 
    public enum MyTracks {One,Two }
    public List<AudioClip> tracks ;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        SoundPref.OnSetTrack +=AddTrack;
    }

    private void OnDisable()
    {
        SoundPref.OnSetTrack -=AddTrack;
    }

    private void AddTrack(MyTracks t)
    {
        _audioSource.clip = tracks[(int)t];
        _audioSource.Play();
    }
}
