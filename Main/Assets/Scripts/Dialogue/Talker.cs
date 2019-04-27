using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talker : MonoBehaviour
{
    public static Talker instace;

    public GameObject TitleObject;
    public GameObject contentObject;
    public GameObject MasterObject;
    public int currentPerson;
    public int currentTalking;
    public bool isTalking;

    public Text[] texs;
    
    // Start is called before the first frame update
    void Start()
    {
        instace = this;

        currentPerson = 0;
        currentTalking = 0;
        isTalking = false;
        removeTalkDia();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if(isTalking == false)
            {
                movebackTalkDia();
                isTalking = true;
            }
            if (Talkof_Test_Group(3))
            {
                removeTalkDia();
                isTalking = false;
            }
        }
    }

    public bool Talkof_Test_Group(int max) {
        //   contentObject.transform.GetComponentInChildren<Text>().text = "Hello!!!";
        
        if (currentTalking <=max)
        {
            MasterObject.transform.Find("TitleofTalkdia").GetComponent<Text>().text = AllTalk.people[currentTalking];
            MasterObject.transform.Find("ContentofTalkDia").GetComponent<Text>().text = AllTalk.contents[currentPerson];
            currentPerson++; currentTalking++;
            return false;
        }
        if (currentTalking > max) {
            return true;
        }
        return false;
    }

    public void removeTalkDia()
    {
        MasterObject.GetComponent<RectTransform>().localPosition = new Vector2(10000, -1050);
    }

    public void movebackTalkDia()
    {
        MasterObject.GetComponent<RectTransform>().localPosition = new Vector2(0,-50);
    }

}

