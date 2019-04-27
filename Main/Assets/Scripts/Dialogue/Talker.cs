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
    public int current;
    public int Talkmax;
    public int currentTalking;  //useless
    public bool isTalking;

    public Text[] texs;

    // Start is called before the first frame update
    void Start()
    {
        MasterObject.SetActive(false);
        instace = this;
        current = 0;
        Talkmax = 0;
        isTalking = false;
        removeTalkDia();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            bool ispressed = true;
            if (isTalking == false && ispressed)
            {
                movebackTalkDia();
                isTalking = true;
                RunNextTalk();
                ispressed = false;
            }
            else if (Test_of_end(current) && ispressed)
            {
                removeTalkDia();
                ispressed = false;
                isTalking = false;
                MasterObject.SetActive(false);
            }

            else if(isTalking == true && ispressed)
            {
                current++;
                ispressed = false;
                RunNextTalk();

            }

        }
    }

    public void setTest_Group(int ini , int max)
    {
        current = ini;
        Talkmax = max;
        MasterObject.transform.Find("TitleofTalkdia").GetComponent<Text>().text = AllTalk.people[current];
        MasterObject.transform.Find("ContentofTalkDia").GetComponent<Text>().text = AllTalk.contents[current];
    }

    public bool Test_of_end(int input)
    {
        if (input == Talkmax)
        {
            return true;
        } else {
            return false;
        }
    }

    public void RunNextTalk()
    {
        MasterObject.transform.Find("TitleofTalkdia").GetComponent<Text>().text = AllTalk.people[current];
        MasterObject.transform.Find("ContentofTalkDia").GetComponent<Text>().text = AllTalk.contents[current];
    }

    public void removeTalkDia()
    {

        MasterObject.GetComponent<RectTransform>().localPosition = new Vector2(10000, -1050);
    }

    public void movebackTalkDia()
    {
        MasterObject.GetComponent<RectTransform>().localPosition = new Vector2(0, -124);
    }



    public void setTalkCont(string input)
    {
        Debug.Log(input);
        switch (input)
        {
            case "name":
                
                break;
            case "Trap":
                Talker.instace.setTest_Group(4,6);
                MasterObject.SetActive(true);
                break;
            default:
                Debug.Log("Unidentified Contact.");
                break;
        }
    }

}

