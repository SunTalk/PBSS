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
        //Debug.Log("AIMovement" + gameObject.tag);
    }

    public override void Exit()
    {

    }

    public override void OnValidate()
    {
        base.OnValidate();
    }
}
