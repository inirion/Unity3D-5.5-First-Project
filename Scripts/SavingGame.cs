using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SavingGame : MonoBehaviour {
    private string _fileName = "savegame.data";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        StreamWriter outFile = File.CreateText(_fileName);
        outFile.WriteLine("savegame001");
        outFile.Close(); 
    }
}
