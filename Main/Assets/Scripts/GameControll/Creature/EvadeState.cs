using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvadeState : Istate
{
    [Header("State")]
    BaseControll baseControll;

    public void Enter(BaseControll baseControll)
    {
        this.baseControll = baseControll;
    }
    public void UPDATE()
    {
        //baseControll.baseMovement.Move( baseControll.baseMovement.StartPosition - baseControll.transform.position);
        //if(baseControll.baseMovement.TargetDistance(baseControll.baseMovement.StartPosition) < 2)
        //{
        //    baseControll.ChangeState(baseControll.idleState);
        //}
    }

    public void Exit()
    {

    }
}
