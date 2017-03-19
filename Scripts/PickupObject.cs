using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour {
    private GameObject mainCamera;
    private bool carrying;
    private GameObject carriedObject;
    [SerializeField]
    private float distance;
    [SerializeField]
    private float smooth;
    // Use this for initialization
    void Start () {
        mainCamera = GameObject.FindWithTag("MainCamera");
        distance = 3;
        smooth = 4;
    }
	
	// Update is called once per frame
	void Update () {
        if (carrying)
        {
            carry(carriedObject);
            checkDrop();
        }else
        {
            
            pickup();
        }
    }

    void carry(GameObject obj)
    {
        obj.transform.position = Vector3.Lerp(obj.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
    }

    void pickup()
    {
        if (Input.GetButtonDown("PickUp"))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if (p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    carriedObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
    }

    void checkDrop()
    {
        if (Input.GetButtonDown("PickUp"))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        carriedObject.GetComponent<Rigidbody>().isKinematic = false;
        carriedObject = null;
    }
}
