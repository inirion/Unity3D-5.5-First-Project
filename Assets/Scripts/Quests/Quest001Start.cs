using UnityEngine.UI;
using UnityEngine;


public class Quest001Start : MonoBehaviour {
    GameObject mainCamera;
    public bool textBoxOnCheck;
    public GameObject messageBox;
    public GameObject textBox;
    public string messageText;
    public GameObject questBox;
    public GameObject questText;
    public string questName;
    int clicks;

    public GameObject QuestItemToShow;

	// Use this for initialization
	void Start () {
        textBoxOnCheck = false;
        clicks = 0;
        mainCamera = GameObject.FindWithTag("MainCamera");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("PickUp"))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "NPC001")
                {
                    if(hit.distance <= 5)
                    {
                        QuestItemToShow.SetActive(true);
                        Click(true);
                        clicks++;
                    }
                }
                else
                {
                    Click(false);
                }
            } 
        }
    }

    void Click(bool show)
    {
        print(textBoxOnCheck);
        if (!show) messageBox.SetActive(show);
        else {
            if (clicks % 2 == 0)
            {
                messageBox.SetActive(false);
            }
            else
            {
                if (!textBoxOnCheck)
                {
                    textBoxOnCheck = true;
                    messageText = "Wieśniak : Ktoś mi zajumał monety, odnajdz je przybyszu!\nSłyszałem że źli ludzie zabrali je do swojego obzu.";
                    textBox.GetComponent<Text>().text = messageText;
                    questName = "Zadanie : Mamona";
                    questText.GetComponent<Text>().text = questName;
                    messageBox.SetActive(true);
                }
                else
                {
                    messageText = "Wieśniak: Spiesz się podróżniku!!";
                    textBox.GetComponent<Text>().text = messageText;
                    messageBox.SetActive(true);
                }
            }
        }
    }

    void DisableTextShown()
    {
        messageBox.SetActive(false);
    }
}
