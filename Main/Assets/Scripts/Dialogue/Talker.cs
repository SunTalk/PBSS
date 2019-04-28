using UnityEngine;
using UnityEngine.UI;

public class Talker : MonoBehaviour
{
    public AudioSource Sfx1;

    public static Talker instace;

    public GameObject TitleObject;
    public GameObject contentObject;
    public GameObject MasterObject;
  //  public GameObject player;
    public int current;
    public int Talkmax;
    public int currentTalking;  //useless
    public bool isTalking;

    public bool has_talk ;
    public bool has_finish_lava ;
    public bool has_finish_ice;
    public Text[] texs;

    // Start is called before the first frame update
    void Start()
    {
        Sfx1.Stop();
        MasterObject.SetActive(false);
        instace = this;
        current = 0;
        Talkmax = 0;
        isTalking = false;
        has_talk = false;
        has_finish_lava = false;
        has_finish_ice = false;
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
                //player.SetActive(true);
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
        current = ini + AllTalk.language_number*AllTalk.language_change_rate;
        Talkmax = max + AllTalk.language_number * AllTalk.language_change_rate;
        movebackTalkDia();
       // player.SetActive(false);
        MasterObject.transform.Find("TitleofTalkdia").GetComponent<Text>().text = AllTalk.people[current];
        MasterObject.transform.Find("ContentofTalkDia").GetComponent<Text>().text = AllTalk.contents[current];
    }

    public void setText_Language(int ini, int max)
    {
        current = ini + AllTalk.language_number * AllTalk.language_change_rate;
        Talkmax = max + AllTalk.language_number * AllTalk.language_change_rate;
    }

        public bool Test_of_end(int input)
    {
        if (input == Talkmax)
        {
            Debug.Log((input == Talkmax) + "," + Talkmax + " "  + input);
            if (input == 6 && isTalking == false)
            {
              //  Sfx1.Play();
            }
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
            case "name": // space for 松松

                //Talker.has_talk = true;
                MasterObject.SetActive(true);
                if (has_talk == false)
                {
                    Talker.instace.setTest_Group(7, 14);
                    has_talk = true;
                }
                else if (has_finish_lava == true  && has_finish_ice == true)
                {
                    MasterObject.SetActive(true);
                    Talker.instace.setTest_Group(2, 3);

                }
                else
                {
                    Talker.instace.setTest_Group(1,1);
                } 
                break;
            case "Trap":
                Talker.instace.setTest_Group(4,6);
                MasterObject.SetActive(true);
                break;
            case "speed_up_staff":  // maybe not used
                                    //ItemSlot.itemslot1.setPicture();
                                    //ItemSlot.itemslot1.erasePicture();
                                    //Debug.Log("it should be shoes.");

                if(Talkmax == 6) Sfx1.Play();
                break;
            case "Ice":
                //Talker.instace.setTest_Group(4, 6);
                has_finish_ice = true;
                //MasterObject.SetActive(true);
                Debug.Log("ice fin");
                break;
            case "Lava":
                //Talker.instace.setTest_Group(4, 6);
                //MasterObject.SetActive(true);
                has_finish_lava = true;
                Debug.Log("lava fin");
                break;
            default:
                Debug.Log("Unidentified Contact.");
                break;
        }
    }

}

