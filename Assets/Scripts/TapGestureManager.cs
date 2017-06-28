using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class TapGestureManager : MonoBehaviour {

    GestureRecognizer recognizer;

    // Use this for initialization
    void Start () {
        recognizer = new GestureRecognizer();
        recognizer.TappedEvent += Recognizer_TappedEvent;
        recognizer.StartCapturingGestures();
    }

    private void Recognizer_TappedEvent(InteractionSourceKind source, int tapCount, Ray headRay)
    {
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;
        RaycastHit hitInfo;

        // did the tap occur on an object
        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            var focusedObject = hitInfo.collider.gameObject;
            focusedObject.SendMessageUpwards("OnTapped");
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
