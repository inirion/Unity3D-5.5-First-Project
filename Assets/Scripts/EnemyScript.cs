using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    [SerializeField]
    private int hp;

    public int Hp
    {
        get{return hp;}

        set{hp = value;}
    }

    // Use this for initialization
    void Start () {
        hp = 50;

    }
	
	// Update is called once per frame
	void Update () {
		if(hp <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void DeductPoints(int hp)
    {
        this.hp -= hp;
    }
}
