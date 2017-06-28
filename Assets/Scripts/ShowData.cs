// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

namespace HoloToolkit.Unity.InputModule
{


    public class ShowData : MonoBehaviour,
                            IInputHandler
    {
        
        public GameObject infoWindow;
        private GameObject Graph;
        private GameObject button;
        private Behaviour halo;

        private bool isGazed;
        private bool showing = false;

        private IInputSource currentInputSource = null;
        private uint currentInputSourceId;
       
        
        
        //for sound feedback
        public AudioClip TargetFeedbackSound;
        private AudioSource audioSource;
        private Transform target;
        




        private void OnDestroy()
        {

        }

        private void Start()
        {
            halo = (Behaviour)GetComponent("Halo");
            Graph = this.transform.Find("Graph").gameObject;
            // button = GameObject.Find("Button").GetComponent<UnityEngine.UI.Button>();
        //    button = GameObject.Find("Button").gameObject;
            halo.enabled = false;
            infoWindow.SetActive(false);
           // button.gameObject.SetActive(false);

            
            EnableAudioHapticFeedback();
        }

        public void UpdateDirection()
        {
            // target = this.transform;
            //  Vector3 relativePos = target.position - Camera.main.transform.position;
            // Quaternion rotation = Quaternion.LookRotation(relativePos);
            //  transform.rotation = rotation;  

            var fwd = Camera.main.transform.forward;
            fwd.y = 0 ;
            transform.rotation = Quaternion.LookRotation(fwd);
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

        public void OnInputUp(InputEventData eventData)
        {
            //nothing
        }



        public void OnInputDown(InputEventData eventData)
        {

            if (showing)
                {
               // if (this.gameObject.tag!="Button")
              //  {
                    infoWindow.SetActive(false);
                    Graph.SetActive(false);
                   // button.gameObject.SetActive(false);

                    showing = false;
                    this.BroadcastMessage("ShowTitle");

                    //Disable highlighting and enable Interactible script                    
                    halo.enabled = false;
                    audioSource.Play();
              //  }

                    
            }
                else
                {
               // if (this.gameObject.tag != "Button")
               // {
                    infoWindow.SetActive(true);
                    Graph.SetActive(true);
                  //  button.gameObject.SetActive(true);
                    this.BroadcastMessage("HideTitle");
                    showing = true;

                    UpdateDirection();
                    //keep ball highlighted    
                    halo.enabled = true;
                    audioSource.Play();
               // }



            }
            

        }

    }
}