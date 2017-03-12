using UnityEngine;
using UnityEngine.UI;

public class Quest001Active : MonoBehaviour {
    public GameObject messageBox;
    public GameObject textBox;

    public GameObject QuestItemToClose;
    public GameObject QuestItemToShow;
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
