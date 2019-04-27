using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        OnValidate();
    }

    void UseProp()
    {
        Debug.Log("Use:" + gameObject.name);
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision is BoxCollider2D)
        {
            if (collision.gameObject.tag == "Player")
            {
                UseProp();
            }
        }
    }

    private void OnValidate()
    {

        Debug.Assert(gameObject.tag != "Untagged", gameObject.name + " Don't set tag");
    }
}
