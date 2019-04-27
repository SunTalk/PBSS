using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    //GameObject 
    public static string CollidResever;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Talker.instace.isTalking == false)
            {
                Talker.instace.movebackTalkDia();
                Talker.instace.isTalking = true;
                CollidResever = this.name.ToString();
            }
        }
    }
}
