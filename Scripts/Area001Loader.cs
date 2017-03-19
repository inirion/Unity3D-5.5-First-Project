using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Area001Loader : MonoBehaviour {
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _startingScript;
    [SerializeField]
    private GameObject _villageBox;
    private Vector3 _playerPos;
    private string _loadedCode;
    [SerializeField ]
    private GameObject _questText;
	// Use this for initialization
	void Start () {
        _playerPos = new Vector3(31.84759f, 2.308079f, 101.9465f);
        _loadedCode = LoadAndNew.GlobalLoad;
        if(_loadedCode == "savegame001")
        {
            _player.transform.position = _playerPos;
            _startingScript.SetActive(false);
            _villageBox.SetActive(false);
            _questText.transform.parent.gameObject.SetActive(true); //pobranie panelu w ktorym znajduje sie tekst
            _questText.GetComponent<Text>().text = "Zadanie : Znajdz wieśniaka.";
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
