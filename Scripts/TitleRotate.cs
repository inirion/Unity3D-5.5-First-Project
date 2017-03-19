using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleRotate : MonoBehaviour {
    private float rotateSpeed;
    private float rotateBarrier;
    private float counter;
	// Use this for initialization
	void Start () {
        rotateSpeed = 0.03f;
        rotateBarrier = 10f;
    }
	
	// Update is called once per frame
	void Update () {
        counter += rotateSpeed;
        if (counter < rotateBarrier)
            transform.Rotate(0, rotateSpeed, 0, Space.World);
        else if(counter >= rotateBarrier)
        {
            transform.Rotate(0, -rotateSpeed, 0, Space.World);
        }
        if (counter >= 3 * rotateBarrier) counter = 0;
    }
}
