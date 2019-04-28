using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public static ItemSlot itemslot1;
    //public GameObject itemslot1;
    public Sprite shoes;
    // Start is called before the first frame update
    void Start()
    {
        itemslot1 = this;
        //setPicture();
        //Debug.Break();
        //erasePicture(); //Debug.Break();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPicture()
    {
        itemslot1.GetComponent<Image>().sprite = shoes;
    }

    public void erasePicture()
    {
        itemslot1.GetComponent<Image>().sprite = null;
    }
}
