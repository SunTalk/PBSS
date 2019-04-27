using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControll : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        OnValidate();
    }

    #region Animator
    public void PlayIdle()
    {
        DisableAll();

        animator.SetBool("Idle", true);
    }

    public void PlayWalk()
    {
        DisableAll();

        animator.SetBool("Walk", true);
    }

    public void PlayRun()
    {
        DisableAll();

        animator.SetBool("Run", true);
    }

    public void PlayJump()
    {
        DisableAll();

        animator.SetBool("Jump", true);
    }
    public void PlayFly()
    {
        DisableAll();

        animator.SetBool("Fly", true);
    }

    public void PlayFall()
    {
        DisableAll();

        animator.SetBool("Fall", true);
    }

    public void PlayDie()
    {
        animator.SetBool("Die", true);
    }

    public void Die()
    {
        //GameManger.Instance.GameOver();
    }

    public void PlaySprint()
    {
        DisableAll();

        animator.SetBool("Fly", true);
    }

    #endregion

    public void SetController(RuntimeAnimatorController AnimatorController)
    {
        animator.runtimeAnimatorController = AnimatorController;
    }

    public void DisableAll()
    {
        foreach (AnimatorControllerParameter param in animator.parameters)
        {
            animator.SetBool(param.name, false);
        }
    }

    public static bool HasParameter(string paramName, Animator animator)
    {
        foreach (AnimatorControllerParameter param in animator.parameters)
        {
            if (param.name == paramName)
                return true;
        }
        return false;
    }

    #region OnValidate
    private void OnValidate()
    {
        animator = GetComponent<Animator>();
        Debug.Assert(animator != null);
    }
    #endregion
}


