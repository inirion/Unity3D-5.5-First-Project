using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitWood_002 : MonoBehaviour {
    [SerializeField]
    private GameObject _questText;
    [SerializeField]
    private GameObject _playerText;
    [SerializeField]
    private GameObject _playerTextDisplayBox;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider info)
    {
        StartCoroutine(startSequence(1,3,5));
    }

    public IEnumerator startSequence(float time1,float time2,float time3)
    {
        transform.position = new Vector3(0, -100000, 0);
        yield return new WaitForSeconds(time1);
        _playerTextDisplayBox.SetActive(true);
        _playerText.GetComponent<Text>().text = "Tam w oddali widzę wioskę.";
        yield return new WaitForSeconds(time2);
        _playerText.GetComponent<Text>().text = "Lepiej pójdę tam może ktoś będzie w stanie mi wytłumaczyć gdzie jestem.";
        yield return new WaitForSeconds(time3);
        _playerText.GetComponent<Text>().text = "";
        _questText.GetComponent<Text>().text = "Zadanie : Znajdz wieśniaka.";
        _playerTextDisplayBox.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
