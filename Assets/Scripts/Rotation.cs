// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using System;

namespace HoloToolkit.Unity.InputModule
{


    public class Rotation : MonoBehaviour,
                            IManipulationHandler,
                            IInputHandler
    {
        private bool isGazed;
        public float Speed = 10.0f;
        private IInputSource currentInputSource = null;
        private uint currentInputSourceId;
        private HandDraggable HandDraggableScript;
        private Rotation RotationScript;
       
        private void OnDestroy()
        {
            if (isGazed)
            {
                OnFocusExit();
            }
        }

        private void Awake()
        {
            
        }

        public void OnInputUp(InputEventData eventData)
        {
            //nothing
        }

        public void OnInputDown(InputEventData eventData)
        {
            //nothing
        }



        public void OnManipulationStarted(ManipulationEventData eventData)
        {
            //
        }
        public void OnManipulationCompleted(ManipulationEventData eventData)
        {
            //this.enabled = false;
           // HandDraggableScript.enabled = true;
           // RotationScript.enabled = false;
        }

        public void OnManipulationCanceled(ManipulationEventData eventData)
        {

        }



        public void OnManipulationUpdated(ManipulationEventData eventData)
            {
                float multiplier = 1.0f;
                float cameraLocalYRotation = Camera.main.transform.localRotation.eulerAngles.y;

                if (cameraLocalYRotation > 270 || cameraLocalYRotation < 90)
                    multiplier = -1.0f;

                var rotation = new Vector3(eventData.CumulativeDelta.y * -multiplier, eventData.CumulativeDelta.x * multiplier);
                transform.Rotate(rotation * Speed, Space.World);
            }



        public void OnFocusEnter()
        {

            if (isGazed)
            {
                return;
            }

            if (GazeManager.Instance.HitObject.tag != "Cube")
            {
                return;
            }

            isGazed = true;
        }

        public void OnFocusExit()
        {

            if (!isGazed)
            {
                return;
            }

            isGazed = false;
        }

        public void OnSourceDetected(SourceStateEventData eventData)
        {
            // Nothing to do
        }

        public void OnSourceLost(SourceStateEventData eventData)
        {
            if (currentInputSource != null && eventData.SourceId == currentInputSourceId)
            {
                // StopDragging();
            }
        }

    }
}