using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUp : MonoBehaviour {
    [SerializeField]
    private RectTransform _myPanel;
    // Use this for initialization
    void Start () {
        _myPanel.position = new Vector3(Screen.width + _myPanel.rect.x, Screen.height + _myPanel.rect.y);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
