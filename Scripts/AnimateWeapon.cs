using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWeapon : MonoBehaviour {
    private bool _isAttacking;
    private Animation _attackAnimation;
    private AudioSource _attackSound;
    public bool IsAttacking
    {
        get{return _isAttacking; }

        set{ _isAttacking = value;}
    }

    // Use this for initialization
    void Start () {
        _isAttacking = false;
        _attackAnimation = GetComponent<Animation>();
        _attackSound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Attack") && !_attackAnimation.IsPlaying("AttackAnimation"))
        {
            _isAttacking = true;
            _attackSound.Play();
            _attackAnimation.Play("AttackAnimation");
        }
        if (!_attackAnimation.IsPlaying("AttackAnimation"))
        {
            _isAttacking = false;
        }
	}


}
