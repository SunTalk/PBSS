using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : BaseControll
{
    public AIMovement aIMovement;
    public PatrolState patrolState = new PatrolState();

    public override void Start()
    {
        base.Start();

        ChangeState(idleState);
        patrolState.Enter(this);

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

        Debug.Assert(aIMovement != null);
        Debug.Assert(attack != null);
        Debug.Assert(aIMovement != null);
        //Debug.Assert(patrolState != null);
    }
}
