using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShoesItem", menuName = "Item/Shoes")]

[System.Serializable]
public class PropShoes : PropScriptObject
{
    public override void Use(GameObject gameObject)
    {
        base.Use(gameObject);
        Debug.Log("ShoesBuffScriptObject");
        ShoesBuff(gameObject);
    }

    private void ShoesBuff(GameObject gameObject)
    {
        gameObject.GetComponent<BaseMovement>().Speed *= 2;
    }
}
