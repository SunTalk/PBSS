using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public float health = 1f;
    bool dead;

    private void Start()
    {
        OnValidate();
    }

    public void ResetHealth(float h)
    {
        health = h;
    }

    public bool TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0f && !dead)
        {
            OnDeath();
            return true;
        }
        return false;
    }
    //// 死亡時
    private void OnDeath()
    {
        dead = true;
        Destroy();
    }
    private void Destroy()
    {
        //Destroy(gameObject);
        //gameObject.SetActive(false);
    }


    private void OnValidate()
    {

    }
}
