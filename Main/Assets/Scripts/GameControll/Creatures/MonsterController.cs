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
        OnValidate();
    }

    private void FixedUpdate()
    {
        currentState.UPDATE();
        //Debug.Log(currentState);
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
    }
}
