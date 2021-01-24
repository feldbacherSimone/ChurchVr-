using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundManager : MonoBehaviour
{
    public AudioClip[] PianoNotes;
    public AudioSource audioSource;

    [SerializeField]
    List<int> notesPlayed;
    [SerializeField]
    List<int> correctSeqence;
    int timesPlayed = 0;

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
        if (timesPlayed >= correctSeqence.Count)
        {
            for (int i = 0; i < correctSeqence.Count; i++)
            {
                if (notesPlayed[i] != correctSeqence[i]) 
                {
                    notesPlayed.RemoveAt(0);
                    return;
                }
                else
                {
                    riddleIsSolved = true;
                }
                return;
            }
            
        }
        else
            return;
    }
}
