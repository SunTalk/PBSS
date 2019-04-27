using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : MonoBehaviour, Istate
{
    [Header("State")]
    BaseControll baseControll;

    public void Enter(BaseControll baseControll)
    {
        this.baseControll = baseControll;
    }
    public void UPDATE()
    {
        //Debug.Log("DeathState");
    }

    public void Exit()
    {

    }
}
