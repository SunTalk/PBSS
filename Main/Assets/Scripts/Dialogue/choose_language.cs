using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class choose_language : MonoBehaviour
{
    public GameObject languageval;

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
    }
}
