using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


namespace HoloToolkit.Unity.InputModule
{
    public class InspectionAddToList : MonoBehaviour, IInputHandler
    {



        public Button myBytton;
        // Use this for initialization
        void Start() {

        }

        public void AddToList()
        {

        }
        public void OnInputUp(InputEventData eventData)
        {
            //nothing
        }

        public void OnInputDown(InputEventData eventData)
        {
            var result = GetComponent<TextMesh>().text;
            result += "ffff \n";
            GetComponent<TextMesh>().text = result;

        }


        
        // Update is called once per frame
        void Update() {

        }
        }
}
