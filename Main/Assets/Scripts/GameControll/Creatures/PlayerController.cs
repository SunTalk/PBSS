using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseControll
{
    public static PlayerController instance;

    public PlayerMove PlayerMove;
    //public Attack PlayerAttack;

    public override void Start()
    {
        base.Start();
        OnValidate();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!attack.AttackStiffness)
        //{
            PlayerMove.PlayerMoveMent();
        //}
    }



    private void OnValidate()
    {
        // Debug.Log("OnValidate");
        PlayerMove = GetComponent<PlayerMove>();
    }

}
