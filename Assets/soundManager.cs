using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundManager : MonoBehaviour
{
    public AudioClip[] PianoNotes;
    public AudioSource audioSource;
    public AudioSource musicSource;
    public AudioClip vicotrySong;

    [SerializeField]
    List<int> notesPlayed;
    [SerializeField]
    List<int> correctSeqence;
    int timesPlayed = 0;
    public int correctNotes = 0; 

    public soundManager ssoundManager;

  public  bool riddleIsSolved;

    public void PlayPianoNote(int noteIndex)
    {
        audioSource.clip = PianoNotes[noteIndex];
        audioSource.Play();
        timesPlayed++;
        notesPlayed.Add(noteIndex);
        RightSequence(timesPlayed);
        
        
    }
    private void Start()
    {
        ssoundManager = this;
        notesPlayed = new List<int>();
        
    }

    void RightSequence(int inote)
    {
        if(notesPlayed.Count > correctSeqence.Count)
        {
            notesPlayed.RemoveAt(0);
        }
        if (notesPlayed.Count == correctSeqence.Count)
        {
            for (int i = 0; i < correctSeqence.Count; i++)
            {

                if (notesPlayed[i] == correctSeqence[i])
                {
                    correctNotes++;
                    

                }
               

            }
            if (correctNotes >= correctSeqence.Count)
            {
                musicSource.clip = vicotrySong;
                musicSource.Play();
                musicSource.loop = true;
                riddleIsSolved = true;
                notesPlayed.Clear();
            }
            else
              correctNotes = 0;
        }
        else
            
        return;
    }
}
