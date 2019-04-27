using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if (col.gameObject.tag == "Player")
        {
        	col.gameObject.GetComponent<BaseControll>().health.TakeDamage(1);
        }else if (col.gameObject.tag == "Monster")
        {
        	col.gameObject.GetComponent<BaseControll>().health.TakeDamage(1);
        }
    }
    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     Debug.Log("OnCollisionEnter2D");
    // }
}