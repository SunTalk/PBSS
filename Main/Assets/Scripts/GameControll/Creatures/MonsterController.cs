using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : BaseControll
{
    public AIMovement aIMovement;

    public override void Start()
    {
        base.Start();
        OnValidate();
    }

    private void FixedUpdate()
    {
        currentState.UPDATE();
    }

    public override void OnValidate()
    {
        base.OnValidate();

        aIMovement = GetComponent<AIMovement>();
        Debug.Assert(aIMovement != null);
    }
}
