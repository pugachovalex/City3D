using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HoloToolkit.Unity.InputModule
{


public class ShowMap : MonoBehaviour,IInputHandler {

	// Use this for initialization
	void Start () {
            var parent = transform.parent.gameObject;
            parent.SetActive(true);
            var MainMap = GameObject.Find("MotionS4");
            MainMap.SetActive(false);
            var Light = GameObject.Find("Directional light");
            Light.SetActive(false);
        }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnInputUp(InputEventData eventData)
        {
            
        }

    public void OnInputDown(InputEventData eventData)
        {

            var Light = GameObject.FindGameObjectWithTag("Light");
            Light.SetActive(true);
            var MainMap = GameObject.FindGameObjectWithTag("MotionS4");
            MainMap.SetActive(true);

        }


    }
}