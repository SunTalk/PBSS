using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseControll
{
    public PlayerMove PlayerMove;
    //public Attack PlayerAttack;
    //public Health PlayerHealth;

    public override void Start()
    {
        base.Start();
        OnValidate();
    }

    // Update is called once per frame
    void Update()
    {
        //if (!attack.AttackStiffness)
        //{
            PlayerMove.PlayerMoveMent();
        //}
    }



    public override void OnValidate()
    {
        base.Start();
        PlayerMove = GetComponent<PlayerMove>();
    }

}
