using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Button : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;
    public GameObject LanguageMenu;
    public static Start_Button instace;

    // Start is called before the first frame update
    void Start()
    {
        LanguageMenu.SetActive(false);
        player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        menu.SetActive(false);
        Talker.instace.MasterObject.SetActive(true);
        player.SetActive(true);
        // first talk
        Talker.instace.movebackTalkDia();
        Talker.instace.isTalking = true;
        Talker.instace.RunNextTalk();
        // Talker.instace.ispressed = false;
        TimerDownCount.instance.StartTimer();
    }
}
