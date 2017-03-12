using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    int hp = 50;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hp <= 0)
        {
            Destroy(gameObject);
        }
	}

    void DeductPoints(int hp)
    {
        this.hp -= hp;
    }
}
