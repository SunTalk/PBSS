using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropController : MonoBehaviour
{
    public PropScriptObject propScriptObject;

    // Start is called before the first frame update
    void Start()
    {
        OnValidate();
    }

    void UseProp(GameObject gO)
    {
        Debug.Log("Use:" + gameObject.name);
        propScriptObject.Use(gO);
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision is BoxCollider2D)
        {
            if (collision.gameObject.tag == "Player")
            {
                UseProp(collision.gameObject);
            }
        }
    }

    private void OnValidate()
    {
        Debug.Assert(propScriptObject != null);
        Debug.Assert(gameObject.tag != "Untagged", gameObject.name + " Don't set tag");
    }
}
