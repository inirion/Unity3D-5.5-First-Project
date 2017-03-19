using UnityEngine;
using UnityEngine.UI;

public class Quest001Active : MonoBehaviour {
    [SerializeField]
    private GameObject messageBox;
    [SerializeField]
    private GameObject textBox;
    [SerializeField]
    private GameObject questText;
    [SerializeField]
    private GameObject QuestItemToClose;
    [SerializeField]
    private GameObject QuestItemToShow;

    public GameObject MessageBox
    {
        get{return messageBox;}

        set{messageBox = value;}
    }

    public GameObject TextBox
    {
        get{return textBox;}

        set{textBox = value;}
    }

    public GameObject QuestItemToClose1
    {
        get{return QuestItemToClose;}

        set{QuestItemToClose = value;}
    }

    public GameObject QuestItemToShow1
    {
        get{return QuestItemToShow;}

        set{QuestItemToShow = value;}
    }

    private
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("PickUp"))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = GameObject.FindWithTag("MainCamera").GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "LootBagQuest001")
                {
                    if (hit.distance <= 5)
                    {

                        Click(true);
                    }
                }
            }
        }
    }

    void Click(bool b)
    {
        if (b)
        {
            messageBox.SetActive(true);
            textBox.GetComponent<Text>().text = "Znalazłeś złoto!";
            questText.GetComponent<Text>().text = "Zadanie : Oddaj worek ze złotem";
            Invoke("HideMessage", 3);
            gameObject.SetActive(false);
            QuestItemToClose.SetActive(false);
            QuestItemToShow.SetActive(true);

        }
    }

    void HideMessage()
    {
        messageBox.SetActive(false);
    }
}
