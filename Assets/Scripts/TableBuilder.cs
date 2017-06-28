using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class TableBuilder : MonoBehaviour {
    private string DataPath = "";
    private GameObject ParentSphere;
    // Use this for initialization
    void Start() {
        var result = "";
        var parentName = transform.parent.name;
        var s = "Sphere1";        
        DataPath = "Assets\\Data\\Values\\" + parentName + ".csv";
        var lines = File.ReadAllLines(DataPath);
        

        for (int i = 0; i < lines.Length; i++)
        {
            var fields = lines[i].Split(',');
            result += fields[0] + "     " + fields[1] + "\n";
        }

       // GetComponent<TextMesh>().text = result;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
