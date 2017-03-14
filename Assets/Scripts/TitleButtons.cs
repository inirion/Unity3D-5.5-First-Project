using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if(GUI.Button (new Rect(Screen.width/2 - (Screen.width / 7)/2, Screen.height / 2, Screen.width/7, 30), "Graj"))
        {
            SceneManager.LoadScene(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - (Screen.width / 7) / 2, Screen.height / 2 +50 , Screen.width / 7, 30), "Wyjdz"))
        {
            Application.Quit();
        }
    }
}
