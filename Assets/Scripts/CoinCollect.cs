using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {
    private CoinSystem coinSystem;
    // Use this for initialization
    void Start () {
        coinSystem = GameObject.Find("ScoreCounter").GetComponent<CoinSystem>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider info)
    {
        coinSystem.CoinsCollected++;
        Destroy(gameObject);
    }
}
