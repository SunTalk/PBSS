using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BaseMovement : MonoBehaviour, Istate
{
    [Header("Basic")]
    public float Speed = 5f;
    public bool moving = false;
    public Vector2 lastMove;
    public Vector3 StartPosition;
    [Header("OnValidate")]
    protected BaseControll baseControll;
    [Header("Chasing")]
    public bool Chasing = false;
    Vector3 Destination;
    Vector3 Direction;

    [Header("delegate")]
    public AnimationPlay animationPlay;
    public delegate void AnimationPlay(float x, float y, Vector2 lastMove, bool moving);

    public virtual void Enter(BaseControll baseControll)
    {
    }
    public virtual void UPDATE()
    {
        //if (animationPlay != null)
        //{
        //    animationPlay(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), lastMove, moving);
        //}
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

    public virtual void Exit()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

    }

    public float TargetDistance(Vector3 direction)
    {
        return Vector2.Distance(transform.position, direction);
    }
    // Chase or Attack
    public virtual bool ChaseTarget()
    {
        return false;
    }

    public void ChasingTarget(Vector3 destination)
    {
        Chasing = true;
        Destination = destination;
        Move(Destination - transform.position);
    }

    public virtual void Move(Vector3 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
        moving = true;
    }

    public virtual void OnValidate()
    {
        baseControll = GetComponent<BaseControll>();
        Debug.Assert(baseControll != null);
        StartPosition = transform.position;
    }
}
