using UnityEngine.UI;
using UnityEngine;


public class Quest001End : MonoBehaviour
{
    public GameObject messageBox;
    public GameObject textBox;
    public GameObject questBox;
    public GameObject questText;
    public int clicks;

    // Use this for initialization
    void Start()
    {
        clicks = 0;
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
                if (hit.collider.tag == "NPC001")
                {
                    if (hit.distance <= 5)
                    {
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
        if (!show) messageBox.SetActive(show);
        else {
            if (clicks % 2 == 0)
            {
                messageBox.SetActive(false);
            }
            else
            {
                textBox.GetComponent<Text>().text = "Wieśniak : Dzięki wielkie za pomoc!";
                questText.GetComponent<Text>().text = "Zadanie :";
                messageBox.SetActive(true);
            }
        }
    }
}
