using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class VoiceCommandsHandler : MonoBehaviour{


    public HandDraggable HandDraggableScript;
    public HandRotate HandRotateScript;

    //for sound feedback
    public AudioClip FeedbackDrag, FeedbackRotate;
    private AudioSource audioSource1, audioSource2;

    // Use this for initialization
    void Start ()
    {
        HandDraggableScript.SetDragging(true);
        HandRotateScript.SetRotating(false);

        EnableAudioHapticFeedback();
    }

    private void EnableAudioHapticFeedback()
    {
        // If this hologram has an audio clip, add an AudioSource with this clip.
        if (FeedbackRotate != null)
        {
            audioSource1 = GetComponent<AudioSource>();
            if (audioSource1 == null)
            {
                audioSource1 = gameObject.AddComponent<AudioSource>();
            }

            audioSource1.clip = FeedbackRotate;
            audioSource1.playOnAwake = false;
            audioSource1.spatialBlend = 1;
            audioSource1.dopplerLevel = 0;
        }

        if (FeedbackDrag != null)
        {
            audioSource2 = GetComponent<AudioSource>();
            if (audioSource2 == null)
            {
                audioSource2 = gameObject.AddComponent<AudioSource>();
            }

            audioSource2.clip = FeedbackDrag;
            audioSource2.playOnAwake = false;
            audioSource2.spatialBlend = 1;
            audioSource2.dopplerLevel = 0;
        }
    }



    public void EnableRotation()
    {
       // audioSource2.Play();
        HandDraggableScript.SetDragging(false);
        HandRotateScript.SetRotating(true);
    }

    public void PlayDraggingFeedback()
    {
         //audioSource1.Play();

    }

    public void EnableDragging()
    {
        
        HandDraggableScript.SetDragging(true);
        HandRotateScript.SetRotating(false);
    }
}
