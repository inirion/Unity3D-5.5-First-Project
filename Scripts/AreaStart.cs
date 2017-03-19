using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaStart : MonoBehaviour {
    [SerializeField]
    private GameObject _blackScreen;
    [SerializeField]
    private GameObject _fadeScreen;
    private Animator _fadeAnimation;
	// Use this for initialization
	void Start () { 
        _fadeAnimation = _fadeScreen.GetComponent<Animator>();
        StartCoroutine("Fade");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(1.0f);
        _fadeAnimation.enabled = true;
        _blackScreen.SetActive(false);
        yield return new WaitForSeconds(1.0f - 0.01f);
        _fadeAnimation.enabled = false;
        _fadeScreen.SetActive(false); 
    }
}
