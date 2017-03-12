using UnityEngine;
using System.Collections;


public class GetObject : MonoBehaviour
{
    void Update()
    {
        RaycastHit hit;
        var cameraCenter = GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, GetComponent<Camera>().nearClipPlane));
        if (Physics.Raycast(cameraCenter, this.transform.forward, out hit, 1000))
        {
            var obj = hit.transform.gameObject;
            if(obj.tag == "Log001")
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