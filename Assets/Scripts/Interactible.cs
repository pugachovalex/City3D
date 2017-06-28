using UnityEngine;
using System;


namespace HoloToolkit.Unity.InputModule
{
    /// <summary>
    /// The Interactible class flags a Game Object as being "Interactible".
    /// Determines what happens when an Interactible is being gazed at.
    /// </summary>
    public class Interactible : MonoBehaviour
                                
                                
    {
        //  private Behaviour halo;
        [Tooltip("Audio clip to play when interacting with this hologram.")]
        public AudioClip TargetFeedbackSound;
        private AudioSource audioSource;
       // public GameObject nodeTitle;
        private bool showingTitle = true;
        private Color originalColor;
        


        void Start()
        {
            
            var CurrentObject = this.GetComponent<Renderer>();
            originalColor = CurrentObject.material.color;

            // Add a BoxCollider if the interactible does not contain one.
            Collider collider = GetComponentInChildren<Collider>();
            if (collider == null)
            {
                gameObject.AddComponent<BoxCollider>();
            }
            EnableAudioHapticFeedback();
            

            //hide DataWindow
            
    }
              

        private void EnableAudioHapticFeedback()
        {
            // If this hologram has an audio clip, add an AudioSource with this clip.
            if (TargetFeedbackSound != null)
            {
                audioSource = GetComponent<AudioSource>();
                if (audioSource == null)
                {
                    audioSource = gameObject.AddComponent<AudioSource>();
                }

                audioSource.clip = TargetFeedbackSound;
                audioSource.playOnAwake = false;
                audioSource.spatialBlend = 1;
                audioSource.dopplerLevel = 0;
            }
        }

        void HideTitle()
        {
            showingTitle = false;
        }

        void ShowTitle()
        {
            showingTitle = true;
        }


        /* TODO: DEVELOPER CODING EXERCISE 2.d */

        void GazeEntered()
        {
            var CurrentObject = this.GetComponent<Renderer>();
            var color = CurrentObject.material.color;
            var brigherColor = new Color(color.r * 1.5f, color.g * 1.5f, color.b * 1.5f, color.a);
            CurrentObject.material.color = brigherColor;


            if (showingTitle)
            {
                // nodeTitle.SetActive(true); //for demo!
            }

        }

        void GazeExited()
        {
            var CurrentObject = this.GetComponent<Renderer>();
            CurrentObject.material.color = originalColor;

            //  nodeTitle.SetActive(false);         

        }

    }
}