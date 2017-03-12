using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public Transform target;
    public bool pickUp;
	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (pickUp)
        {
            if (Input.GetButtonDown("PickUp"))
            {
                this.transform.position = target.position;
                this.transform.parent = GameObject.Find("FPSController").transform;
                this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
            }
            if (Input.GetButtonUp("PickUp"))
            {
                this.transform.parent = GameObject.Find("FPSController").transform;
                this.transform.position.Set(target.position.x, target.position.y, target.position.z);
                this.transform.parent = null;
            }
        }
    }
    void OverLog001(bool pick)
    {
        pickUp = pick;
    }
}
