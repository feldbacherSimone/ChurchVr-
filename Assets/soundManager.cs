using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundManager : MonoBehaviour
{
    public AudioClip[] PianoNotes;
    public AudioSource audioSource; 



    public void PlayPianoNote(int noteIndex)
    {
        audioSource.clip = PianoNotes[noteIndex];
        audioSource.Play();

        
    }
    
}
