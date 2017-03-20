using UnityEngine.UI;
using UnityEngine;
using System.Collections;

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
            if (PlayerCasting.Instance.HittedTarget.distance <= 5 && PlayerCasting.Instance.HittedTarget.transform.name == "QuestEnd_001")
            {
                StartCoroutine(Click());
            }
        }
    }

    private IEnumerator Click()
    {

        messageBox.SetActive(true);
        textBox.GetComponent<Text>().text = "Wieśniak : Dzięki wielkie za pomoc!";
        yield return new WaitForSeconds(2.0f);
        questText.GetComponent<Text>().text = "Zadanie :";   
        messageBox.SetActive(false);
    }
}
