using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
    /*
    **This script is attached to main contorller(player) and targets are list of object that player
    **is going to teleport to. Tag is tag given in unity editor to teleport reciver to distinct recivers.
    **To add new teleport add size in unity attach new reciver and tag teleport(entrence).
    */
    [SerializeField]
    private List<Transform> warpTarget;
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
            this.transform.position = warpTarget[0].position;
        }
        if (collider.gameObject.tag == "warp002")
        {
            this.transform.position = warpTarget[1].position;
        }
    }

}
