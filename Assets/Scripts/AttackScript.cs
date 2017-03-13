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
    private AnimateWeapon weapon;

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
        weapon = GameObject.Find("Weapon").GetComponent<AnimateWeapon>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Attack"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit)){
                ToTarget = hit.distance;
                if(ToTarget < Range && !weapon.IsAttacking)
                {
                    hit.transform.GetComponent<EnemyScript>().DeductPoints(Damage);
                    //hit.transform.SendMessage("DeductPoints", Damage, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
	}
}
