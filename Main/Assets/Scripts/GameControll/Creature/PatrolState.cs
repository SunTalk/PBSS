using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour, Istate
{
    [Header("State")]
    BaseControll baseControll;

    [Header("PatrolPara")]
    public Transform PatrolPointParent;
    public float PatrolSpeed = 0.5f; 
    private bool IsPatrol = false;

    [SerializeField]
    private int CurrentPatrolPint = 0;

    void Start()
    {
        //Debug.Assert(PatrolPointParent != null, gameObject.name);
    }

    public void Enter(BaseControll baseControll)
    {
        this.baseControll = baseControll;
    }
    public void UPDATE()
    {
        //Debug.Log("PatrolState");
        if (baseControll.attack.targetObject != null)
        {
            baseControll.ChangeState(baseControll.baseMovement);
        }
        else
        {
            StartCoroutine(DelayPatrol());
            baseControll.ChangeState(baseControll.baseMovement);
        }
    }
    public void Exit()
    {

    }
    public bool IsNeedPatrol()
    {
        return IsPatrol;
    }
    public Vector3 GetPatrolPosition()
    {
        return PatrolPointParent.GetChild(CurrentPatrolPint).transform.position;
    }
    public void SetNextPatrolPoint()
    {
        IsPatrol = false;
        if ( CurrentPatrolPint < PatrolPointParent.childCount-1)
        {
            CurrentPatrolPint++;
        }
        else
        {
            CurrentPatrolPint = 0;
        }
    }

    private IEnumerator DelayPatrol()
    {
        yield return new WaitForSeconds(1);
        IsPatrol = true;

    }
}
