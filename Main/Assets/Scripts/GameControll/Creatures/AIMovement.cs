using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : BaseMovement
{
    public Attack attack;
    public PatrolState patrolState;

    private void Start()
    {
        OnValidate();
    }

    public override void UPDATE()
    {
        base.UPDATE();
        //Debug.Log("AIMovement");
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
        else if(patrolState.IsNeedPatrol())
        {
            Move2PatrolPoint();
        }
        else
        {
            baseControll.ChangeState(baseControll.idleState);
        }
    }

    public override void Exit()
    {

    }

    public override bool ChaseTarget()
    {
        float distance = TargetDistance(baseControll.attack.targetObject.transform.position);
        if (distance > (baseControll.DetectDistance * baseControll.AttackDistance))
        {
            return true;
        }
        return false;
    }

    private void Move2PatrolPoint()
    {
        float distance = TargetDistance(patrolState.GetPatrolPosition());
        if (distance > 2)
        {
            transform.position = Vector3.Lerp(transform.position, patrolState.GetPatrolPosition(), patrolState.PatrolSpeed * Time.deltaTime);
        }
        else
        {
            patrolState.SetNextPatrolPoint();
        }
    }

    public override void OnValidate()
    {
        base.OnValidate();
        attack = GetComponent<Attack>();
        patrolState = GetComponent<PatrolState>();
        Debug.Assert(patrolState != null);
        Debug.Assert(attack != null);
    }
}
