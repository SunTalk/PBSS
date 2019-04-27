using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum IstateType { }

public class BaseControll : MonoBehaviour
{
    [Header("State")]
    public Istate currentState;
    public IdleState idleState = new IdleState();
    public EvadeState evadeState = new EvadeState();
    public PatrolState patrolState;
    public DeathState deathState;
    public BaseMovement baseMovement;
    public Attack attack;
    public Health health;
    [Header("Collider")]
    public float DetectDistance;
    public float AttackDistance;

    public virtual void Start()
    {
        idleState.Enter(this);
        evadeState.Enter(this);
    }

    public void ChangeState(Istate state)
    {
        if (currentState != null) currentState.Exit();
        currentState = state;
        Debug.Assert(currentState != null);
    }

    protected void onValidate()
    {
        //Debug.Log("BaseControll");
        //attack = GetComponent<Attack>();
        baseMovement = GetComponent<BaseMovement>();
        health = GetComponent<Health>();
        DetectDistance = GetComponent<CircleCollider2D>().radius;

        Debug.Assert(gameObject.tag != "Untagged", gameObject.name + " Don't set tag");
        //Debug.Assert(attack != null, gameObject.name);
        Debug.Assert(health != null, gameObject.name);
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawWireSphere(gameObject.transform.position, GetComponent<BoxCollider2D>().size.x);
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(gameObject.transform.position, DetectDistance);
    //}
}
