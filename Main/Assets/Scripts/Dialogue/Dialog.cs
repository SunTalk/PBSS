using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    //GameObject 
    public static string CollidResever;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.ToString() == "Player")
        {
            if (Talker.instace.isTalking == false)
            {
                Talker.instace.movebackTalkDia();
                Talker.instace.isTalking = true;
                CollidResever = this.name.ToString();
                Talker.instace.setTalkCont(CollidResever.ToString());
                Debug.Log(CollidResever);
            }
        }
    }
}
