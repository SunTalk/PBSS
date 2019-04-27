using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AI;

public class Attack : MonoBehaviour, Istate
{
    [Header("OnValidate")]
    public BaseMovement baseMovement;
    protected BaseControll baseControll;

    [Header("delegate")]
    public AnimationPlay animationPlay;
    public delegate void AnimationPlay(bool Attacking);

    [Header("Para")]
    public GameObject targetObject;
    public bool readyAttack = true;
    public bool AttackStiffness = false;
    public float AtkSpeed = 1f;
    public float AtkPower = 1f;

    private void Start()
    {
        OnValidate();
    }

    private void OnValidate()
    {
        baseMovement = GetComponent<BaseMovement>();
        baseControll = GetComponent<BaseControll>();

        Debug.Assert(GetComponent<CircleCollider2D>().isTrigger == true);
        Debug.Assert(baseMovement != null);
        Debug.Assert(baseControll != null);
    }

    public void Enter(BaseControll baseControll)
    {
    }
    public void UPDATE()
    {
        //Debug.Log("AttackState");
        if (targetObject == null)
        {
            baseControll.ChangeState(baseControll.idleState);
        }
        else if (baseControll.baseMovement.ChaseTarget())
        {
            baseControll.ChangeState(baseControll.baseMovement);
        }
        else if(readyAttack)
        {
            AttackCommand();
        }
    }

    public void Exit()
    {

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(AttackAble(collision.gameObject) + " " + !baseMovement.moving + " " + readyAttack + "\n\n");

        if (AttackAble(collision.gameObject) && targetObject == null)
        {
            LockAttackTarget(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == targetObject)
        {
            targetObject = null;
        }
    }

    private void AttackCommand()
    {
        //Debug.Log("Attack Player");
        StartCoroutine(AttackTarget(targetObject.GetComponent<Health>()));
    }



    // 鎖定敵方目標
    private void LockAttackTarget(GameObject target)
    {
        targetObject = target;
    }

    private IEnumerator AttackTarget(Health target)
    {
        readyAttack = false;
        AttackStiffness = true;
        if (animationPlay != null) animationPlay(AttackStiffness);
        yield return new WaitForSeconds(1 / AtkSpeed);

        //if( target.TakeDamage(1) ) targetObject = null;

        AttackStiffness = false;
        if (animationPlay != null) animationPlay(AttackStiffness);
        readyAttack = true;
    }

    public bool AttackAble(GameObject target)
    {
        if (target.gameObject.tag != this.gameObject.tag &&
                (target.gameObject.tag == "Player" || target.gameObject.tag == "Monster"))
        {
            return true;
        }
        return false;
    }

}
