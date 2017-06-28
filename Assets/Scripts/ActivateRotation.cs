using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule
{
    public class RotationHandler : MonoBehaviour, ISpeechHandler
    {

        private Rotation RotationScript;
        private HandDraggable HandDraggableScript;

        // Use this for initialization
        void Start()
        {
            RotationScript = GetComponent<Rotation>();
            RotationScript.enabled = false;
            HandDraggableScript = GetComponent<HandDraggable>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnSpeechKeywordRecognized(SpeechKeywordRecognizedEventData eventData)
        {
                     
                RotationScript.enabled = true;
                HandDraggableScript.enabled = false;
            
        }
    }
}
