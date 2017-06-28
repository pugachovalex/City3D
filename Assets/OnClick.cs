using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace HoloToolkit.Unity.InputModule
{


    public class OnClick : MonoBehaviour
    {
        public Button yourButton;
        public GameObject InspectionList;

        

        void Start()
        {
            //Button btn = yourButton.GetComponent<Button>();
          //  btn.onClick.AddListener(TaskOnClick);
        }

        public void TaskOnClick()
        {
            
            var result = InspectionList.GetComponent<TextMesh>().text;
            var SphereID = GameObject.Find("infoText").GetComponent<TextMesh>().text;
            string[] lines = SphereID.Split('\n');
            result += lines[0] + "\n";
            InspectionList.GetComponent<TextMesh>().text = result;
        }
    }
}
