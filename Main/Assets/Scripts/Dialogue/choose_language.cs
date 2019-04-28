using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class choose_language : MonoBehaviour
{
    public GameObject languageval;
    public GameObject start_button;
    public GameObject language_button;
    public GameObject quit_button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void valueChange()
    {
        AllTalk.language_number = languageval.GetComponent<Dropdown>().value;
        Debug.Log("alltak = " + AllTalk.language_number);

        start_button.GetComponentInChildren<Text>().text = AllTalk.Buttontypes[0+ 3 * AllTalk.language_number];
        language_button.GetComponentInChildren<Text>().text = AllTalk.Buttontypes[1+ 3 * AllTalk.language_number];
        quit_button.GetComponentInChildren<Text>().text = AllTalk.Buttontypes[2+ 3 * AllTalk.language_number];

    }
}
