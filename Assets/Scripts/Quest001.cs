using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Quest001 : MonoBehaviour {
    public bool textBoxOnCheck;
    public GameObject messageBox;
    public GameObject textBox;
    public string messageText;
    public GameObject questBox;
    public GameObject questText;
    public string questName;

	// Use this for initialization
	void Start () {
        textBoxOnCheck = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("PickUp"))
        {
            if (textBoxOnCheck == true)
            {
                textBoxOnCheck = false;
                messageText = "Wieśniak: Czekam na moją mamone !!";
                textBox.GetComponent<Text>().text = messageText;
                messageBox.SetActive(false);
            }
            Click();

        }
        

    }

    void Click()
    {
        
        if(!textBoxOnCheck)
        {
            print("klik");
            textBoxOnCheck = true;
            messageText = "Wieśniak : Ktoś mi zajumał monety, odnajdz je przybyszu !";
            textBox.GetComponent<Text>().text = messageText;
            questName = "Zadanie : Mamona";
            questText.GetComponent<Text>().text = questName;
            messageBox.SetActive(true);
        }
        else
        {
            textBoxOnCheck = false;
            messageBox.SetActive(false);
        }
    }
}
