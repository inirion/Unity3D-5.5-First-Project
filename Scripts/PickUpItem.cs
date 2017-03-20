using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour {
    private float _distance;
    [SerializeField]
    private GameObject _textDisplay;
    [SerializeField]
    private GameObject _fakeItem;
    [SerializeField]
    private GameObject _realItem;
	// Use this for initialization
	void Start () {
        _distance = PlayerCasting.Instance.HittedTarget.distance;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        _distance = PlayerCasting.Instance.HittedTarget.distance;
        PickUpWeapon();
	}

    void OnMouseOver()
    {
        if (_distance <=2.0f)
        {
            _textDisplay.GetComponent<Text>().text = "Podnieś przedmiot";
        }
    }

    void OnMouseExit()
    {
         _textDisplay.GetComponent<Text>().text = "";
    }

    void PickUpWeapon()
    {
        if (Input.GetButtonDown("PickUp") && PlayerCasting.Instance.HittedTarget.transform.name == "PickUpAxeTomahawk")
        {
            if(_distance <= 2.0f)
            {
                transform.position = new Vector3(0, -1000, 0);
                _realItem.SetActive(true);
                _fakeItem.SetActive(false);
                _textDisplay.GetComponent<Text>().text = "";
            }
        }
    }
}
