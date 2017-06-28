using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendInspection : MonoBehaviour {


    private string Data;
    private GameObject InspectionList;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void  EventOnClick()
    {
        Data = this.transform.GetComponent<TextMesh>().text;
        InspectionList = GameObject.Find("InspectionList");
        InspectionList.GetComponent<TextMesh>().text = "LOLO";
        //address to textmesh and add it to the inspection list.
        Data = "";
    }
}
