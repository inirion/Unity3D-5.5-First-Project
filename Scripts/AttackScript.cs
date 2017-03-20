using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour {
    [SerializeField]
    private int damage;
    [SerializeField]
    private float toTarget;
    [SerializeField]
    private float range;

    public int Damage
    {
        get{return damage;}

        set{damage = value;}
    }

    public float ToTarget
    {
        get{return toTarget;}

        set{toTarget = value;}
    }

    public float Range
    {
        get{return range;}
        set{range = value;}
    }

    // Use this for initialization
    void Start () {
        Damage = 10;
        Range = 5;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Attack") && GameObject.Find("Weapon") != null)
        {
            if(ToTarget < Range && !GameObject.Find("Weapon").GetComponent<AnimateWeapon>().IsAttacking)
            {
                if(PlayerCasting.Instance.HittedTarget.transform.GetComponent<EnemyScript>() != null)// if hitted target have EnemyScript attached
                    PlayerCasting.Instance.HittedTarget.transform.GetComponent<EnemyScript>().DeductPoints(Damage);
            }
        }
	}
}
