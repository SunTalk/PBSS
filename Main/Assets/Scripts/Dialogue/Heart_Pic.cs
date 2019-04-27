﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart_Pic : MonoBehaviour
{
    public GameObject heartpict;
    public Sprite heartgot0;
    public Sprite heartgot1;
    public Sprite heartgot2;
    public Sprite heartgot3;
    //  public   Resources.Load<Sprite>("heart4");
    // Start is called before the first frame update
    void Start()
    {
        heartpict.GetComponent<Image>().sprite = heartgot2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHeart()
    {
        if(heartpict.GetComponent<Image>().sprite == heartgot1)
            heartpict.GetComponent<Image>().sprite = heartgot2;
        if (heartpict.GetComponent<Image>().sprite == heartgot2)
            heartpict.GetComponent<Image>().sprite = heartgot3;
    }

    public void DelHeart()
    {
        if (heartpict.GetComponent<Image>().sprite == heartgot3)
            heartpict.GetComponent<Image>().sprite = heartgot2;
        if (heartpict.GetComponent<Image>().sprite == heartgot2)
            heartpict.GetComponent<Image>().sprite = heartgot1;
        if (heartpict.GetComponent<Image>().sprite == heartgot1)
            heartpict.GetComponent<Image>().sprite = heartgot0;
    }
}
