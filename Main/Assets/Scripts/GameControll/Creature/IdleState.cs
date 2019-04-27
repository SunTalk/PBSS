using System;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : Istate
{
    [Header("State")]
    BaseControll baseControll;

    public void Enter(BaseControll baseControll)
    {
        this.baseControll = baseControll;
    }
    public void UPDATE()
    {
        //Debug.Log("Idle");
        if (baseControll.attack.targetObject != null)
        {
            baseControll.ChangeState(baseControll.baseMovement);
        }
        // Go back to position
        else if( baseControll.baseMovement.TargetDistance(baseControll.baseMovement.StartPosition)>2 )
        {
            baseControll.ChangeState(baseControll.evadeState);
        }
    }

    public void Exit()
    {

    }
}
