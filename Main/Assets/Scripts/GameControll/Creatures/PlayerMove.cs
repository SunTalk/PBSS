﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : BaseMovement
{
    public AnimatorControll animatorControll;
    public void PlayerMoveMent()
    {
        moving = false;
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
            animatorControll.PlayDown();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
            animatorControll.PlayDown();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.up);
            lastMove = new Vector2(0, Input.GetAxisRaw("Vertical"));
            animatorControll.PlayUp();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.down);
            lastMove = new Vector2(0, Input.GetAxisRaw("Vertical"));
            animatorControll.PlayDown();
        }
        else{
            animatorControll.PlayIdle();
        }

        if (animationPlay != null)
        {
            animationPlay(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), lastMove, moving);
        }

    }

    #region OnValidate
    public override void OnValidate()
    {
        base.OnValidate();
        animatorControll = GetComponent<AnimatorControll>();
        //Debug.Assert(animatorControll != null);
    }
    #endregion
}
