using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour {
    public int damage;
    public float toTarget;
    public float range;
	// Use this for initialization
	void Start () {
        damage = 10;
        range = 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Attack"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit)){
                toTarget = hit.distance;
                if(toTarget < range && !AnimateWeapon.isAttacking)
                {
                    hit.transform.SendMessage("DeductPoints", damage, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
	}
}
