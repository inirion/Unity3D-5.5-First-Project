using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWeapon : MonoBehaviour {
    [SerializeField]
    private bool isAttacking;
    private Animation attackAnimation;
    public bool IsAttacking
    {
        get{return isAttacking;}

        set{isAttacking = value;}
    }

    // Use this for initialization
    void Start () {
        IsAttacking = false;
        attackAnimation = GetComponent<Animation>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Attack") && !attackAnimation.IsPlaying("AttackAnimation"))
        {
            IsAttacking = true;
            attackAnimation.Play("AttackAnimation");
        }
        if (!attackAnimation.IsPlaying("AttackAnimation"))
        {
            IsAttacking = false;
        }
	}


}
