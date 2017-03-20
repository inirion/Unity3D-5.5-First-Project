using UnityEngine;
using System.Collections;
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
            if (PlayerCasting.Instance.HittedTarget.distance <= 5 && PlayerCasting.Instance.HittedTarget.transform.tag == "LootBagQuest001")
            {

                StartCoroutine(Click());
            }
        }
    }

    private IEnumerator Click()
    {
        messageBox.SetActive(true);
        textBox.GetComponent<Text>().text = "Znalazłeś złoto!";
        yield return new WaitForSeconds(2.0f);
        questText.GetComponent<Text>().text = "Zadanie : Oddaj worek ze złotem";
        QuestItemToClose.SetActive(false);
        QuestItemToShow.SetActive(true);
        messageBox.SetActive(false);
        gameObject.SetActive(false);
    }
}
