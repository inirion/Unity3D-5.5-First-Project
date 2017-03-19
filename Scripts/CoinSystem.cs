using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour {
    [SerializeField]
    private int coinsCollected;

    public int CoinsCollected
    {
        get{return coinsCollected;}

        set{coinsCollected = value;}
    }

    // Use this for initialization
    void Start () {
        CoinsCollected = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10,10,80,40),( "Coins : " + CoinsCollected));
    }
}
