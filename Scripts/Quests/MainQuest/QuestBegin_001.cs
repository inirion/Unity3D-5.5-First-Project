using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestBegin_001 : MonoBehaviour {
    [SerializeField]
    private GameObject _questText;
    [SerializeField]
    private GameObject _playerText;
    [SerializeField]
    private GameObject _playerTextDisplayBox;
	// Use this for initialization
	void Start () {

        transform.position = new Vector3(0, -10000, 0);
        StartCoroutine(startSequence(2));
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public IEnumerator startSequence(float time)
    {
        _playerText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(time);
        _playerTextDisplayBox.SetActive(true);
        _playerText.GetComponent<Text>().text = "Gdzie jestem ?";
        yield return new WaitForSeconds(time);
        _playerText.GetComponent<Text>().text = "Muszę jakoś wydostać się z tego lasu.";
        yield return new WaitForSeconds(time);
        _questText.transform.parent.gameObject.SetActive(true); //pobranie panelu w ktorym znajduje sie tekst
        _questText.GetComponent<Text>().text = "Zadanie : Wyjdz z lasu";
        _playerText.GetComponent<Text>().text = "";
        _playerTextDisplayBox.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
