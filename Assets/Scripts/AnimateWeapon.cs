using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWeapon : MonoBehaviour {
    public static bool isAttacking;
	// Use this for initialization
	void Start () {
        isAttacking = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Attack") && !GetComponent<Animation>().IsPlaying("AttackAnimation"))
        {
            isAttacking = true;
            GetComponent<Animation>().Play("AttackAnimation");
        }
        if (!GetComponent<Animation>().IsPlaying("AttackAnimation"))
        {
            isAttacking = false;
        }
	}


}
