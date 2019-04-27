using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : BaseMovement
{

    private void Start()
    {
        OnValidate();
    }

    public override void UPDATE()
    {
        base.UPDATE();
        Debug.Log("AIMovement" + gameObject.tag);
        //if (baseControll.attack.targetObject != null)
        //{
        //    if (ChaseTarget())
        //    {
        //        ChasingTarget(baseControll.attack.targetObject.transform.position);
        //    }
        //    else
        //    {
        //        baseControll.ChangeState(baseControll.attack);
        //    }
        //}
        //else
        //{
        //    baseControll.ChangeState(baseControll.idleState);
        //}
    }

    public override void Exit()
    {

    }

    public override void OnValidate()
    {
        base.OnValidate();
    }
}
