using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : BaseMovement
{
    public Attack attack;

    private void Start()
    {
        OnValidate();
    }

    public override void UPDATE()
    {
        base.UPDATE();
        Debug.Log("AIMovement" + gameObject.tag);
        if (attack.targetObject != null)
        {
            if (ChaseTarget())
            {
                ChasingTarget(attack.targetObject.transform.position);
            }
            else
            {
                baseControll.ChangeState(attack);
            }
        }
        else
        {
            baseControll.ChangeState(baseControll.idleState);
        }
    }

    public override void Exit()
    {

    }

    public override void OnValidate()
    {
        base.OnValidate();
    }
}
