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
        if (col is BoxCollider2D)
        {
            Debug.Log(col);
            if (col.gameObject.tag == "Player")
            {
                //Debug.Log("Player TakeDamage");
                col.gameObject.GetComponent<BaseControll>().health.TakeDamage(1);
            }else if (col.gameObject.tag == "Monster")
            {
                //Debug.Log("Monster TakeDamage");
                col.gameObject.GetComponent<BaseControll>().health.TakeDamage(1);
            }
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log(collision.gameObject.name);
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        collision.gameObject.GetComponent<BaseControll>().health.TakeDamage(1);
    //    }
    //    else if (collision.gameObject.tag == "Monster")
    //    {
    //        Debug.Log("TakeDamage");
    //        collision.gameObject.GetComponent<BaseControll>().health.TakeDamage(1);
    //    }
    //}
}