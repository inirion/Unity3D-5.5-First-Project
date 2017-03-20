using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Quest001Start : MonoBehaviour {

    public bool textBoxOnCheck;
    public GameObject messageBox;
    public GameObject textBox;
    public string messageText;
    public GameObject questBox;
    public GameObject questText;
    public string questName;
    public GameObject QuestItemToShow;// what will appear in world after quest started

	// Use this for initialization
	void Start () {
        textBoxOnCheck = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("PickUp"))
        {
            if(PlayerCasting.Instance.HittedTarget.distance <= 5 && PlayerCasting.Instance.HittedTarget.transform.name == "QuestStart_001")
            {
                QuestItemToShow.SetActive(true);
                StartCoroutine(Click());
            }
        }
    }

    private IEnumerator Click()
    {
        if (!textBoxOnCheck)
        {
            messageBox.SetActive(true);
            textBoxOnCheck = true;
            messageText = "Wieśniak : Podróżniku potrzebuje twojej pomocy ! Banda zbójów ukradła mi worek ze złotem, odnajdz go a czeka cię wieczna chwała.";
            textBox.GetComponent<Text>().text = messageText;
            yield return new WaitForSeconds(3.0f);
            questName = "Zadanie : Znajdz worek ze złotem";
            questText.GetComponent<Text>().text = questName;
            messageBox.SetActive(false);
        }
        else
        {
            messageBox.SetActive(true);
            messageText = "Wieśniak: Spiesz się podróżniku!!";
            textBox.GetComponent<Text>().text = messageText;
            yield return new WaitForSeconds(3.0f);
            messageBox.SetActive(false);
        }
    }
}
