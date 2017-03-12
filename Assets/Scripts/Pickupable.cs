using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
