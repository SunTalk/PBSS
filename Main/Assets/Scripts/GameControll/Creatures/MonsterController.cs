using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : BaseControll
{
    public AIMovement aIMovement;

    public override void Start()
    {
        base.Start();

        ChangeState(idleState);
        if (patrolState != null)
        {
            //Debug.Log("Evade");
            patrolState.Enter(this);
        }
        else
        {
            //Debug.Log("Create");
            patrolState = new PatrolState();
            patrolState.Enter(this);
            if (patrolState != null)
            {
                Debug.Log("null");
            }
        }
        OnValidate();
    }

    private void FixedUpdate()
    {
        //Debug.Log(currentState);
        currentState.UPDATE();
    }

    private void OnValidate()
    {
        base.onValidate();
        aIMovement = GetComponent<AIMovement>();
        attack = GetComponent<Attack>();
        baseMovement = GetComponent<BaseMovement>();
        patrolState = GetComponent<PatrolState>();
        deathState = GetComponent<DeathState>();

        Debug.Assert(aIMovement != null);
        Debug.Assert(attack != null);
        Debug.Assert(aIMovement != null);
        Debug.Assert(patrolState != null);
        Debug.Assert(deathState != null);
        //Debug.Assert(patrolState != null);
    }
}
