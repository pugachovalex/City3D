using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour {

    private GameObject Graph;
    private GameObject DataSet;
    private Canvas ButtonCanvas;
    

	// Use this for initialization
	void Start () {

        Vector3 thisPosition = this.transform.localPosition;
        Vector3 DeltaTable = new Vector3(3.642f, 6.5841f, 3.6653f); // offset vectors, determined manually
        Vector3 DeltaGraph = new Vector3(-0.432f, 2.5441f, 1.0f); // offset vectors, determined manually       
        Vector3 DeltaButton = new Vector3(2.77f + 6.491f, 4.16f - 0.731f, 0.79f + 2.105f); // offset vectors, determined manually   
        Vector3 DataSetPosition = new Vector3(thisPosition.x + DeltaTable.x , thisPosition.y + DeltaTable.y , thisPosition.z + DeltaTable.z);
        Vector3 GraphPosition = new Vector3(thisPosition.x + DeltaGraph.x, thisPosition.y + DeltaGraph.y, thisPosition.z + DeltaGraph.z);
        
        Graph = this.transform.Find("Graph").gameObject;
        DataSet = this.transform.Find("infoText").gameObject;
        Graph.transform.localPosition = GraphPosition;
        DataSet.transform.localPosition = DataSetPosition;
      //  button = GameObject.Find("Button").gameObject;
        ButtonCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();      
        //var b = button.transform.localPosition.x;
        Vector3 ButtonPosition = new Vector3(thisPosition.x + DeltaButton.x, thisPosition.y + DeltaButton.y, thisPosition.z + DeltaButton.z);
        //ButtonCanvas.transform.position = ButtonPosition;
        
        
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
