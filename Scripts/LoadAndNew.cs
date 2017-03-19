using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadAndNew : MonoBehaviour {
    private string _fileName;
    private string _loadCode;
    private static string _globalLoad;
    [SerializeField]
    private GameObject _noSave;
    public static string GlobalLoad
    {
        get{return _globalLoad;}

        set{_globalLoad = value;}
    }

    // Use this for initialization
    void Start () {
        _fileName = "savegame.data";

        StreamReader ourFile = new StreamReader(_fileName);
        string line = ourFile.ReadLine();
        while (line != null)
        {
            _loadCode += line;
            line = ourFile.ReadLine();
        }
        ourFile.Close();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadGame()
    {
        _globalLoad = _loadCode;
        if (GlobalLoad == "savegame001")
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            _noSave.SetActive(true);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame()  
    {
        _globalLoad = "";
        SceneManager.LoadScene(1);
    }
}
