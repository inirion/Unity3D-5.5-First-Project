using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
    public Transform warpTarget;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "warp001")
        {
            this.transform.position = warpTarget.position;
        }
    }

}
