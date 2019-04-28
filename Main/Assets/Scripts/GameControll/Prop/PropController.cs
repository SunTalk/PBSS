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
        //Debug.Log("Use:" + gameObject.name);
        StartCoroutine(BuffTimer(gO));

    }

    private IEnumerator BuffTimer(GameObject gO)
    {
        propScriptObject.Use(gO);
        StartCoroutine(ReSpawn());
        yield return new WaitForSeconds(propScriptObject.BuffTimer);
        propScriptObject.DeUse(gO);
    }

    private IEnumerator ReSpawn()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(50);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
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
