using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour {
    public static int coinsCollected;
	// Use this for initialization
	void Start () {
        coinsCollected = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10,10,80,40),( "Coins : " + coinsCollected));
    }
}
