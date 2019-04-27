using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public float MaxHealth = 1f;
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

    public int GetHealth()
    {
        return (int)health;
    }

    public void Heal(float h)
    {
        if(health<MaxHealth)health += h;
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
        if (gameObject.tag != "Player") StartCoroutine(Destroy());
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<BaseControll>().ChangeState(gameObject.GetComponent<BaseControll>().deathState);
        //transform.
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        gameObject.SetActive(false);
    }


    private void OnValidate()
    {

    }
}
