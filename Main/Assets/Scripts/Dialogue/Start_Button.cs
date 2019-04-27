using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Button : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;
    public static Start_Button instace;

    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
        StartGame();
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
    }
}
