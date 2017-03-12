using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAtObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        var cameraCenter = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, GetComponent<Camera>().nearClipPlane));
        if (Physics.Raycast(cameraCenter, this.transform.forward, out hit, 1000))
        {
            var obj = hit.transform.gameObject;
            if (obj.tag == "Log001")
            {
                hit.transform.SendMessage("OverLog001", true, SendMessageOptions.DontRequireReceiver);
            }
            else
            {
                hit.transform.SendMessage("OverLog001", false, SendMessageOptions.DontRequireReceiver);
            }

        }
    }
}
