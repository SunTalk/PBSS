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
        //Debug.Log("ShoesBuffScriptObject");
        ShoesBuff(gameObject);
    }

    public override void DeUse(GameObject gameObject)
    {
        base.DeUse(gameObject);
        gameObject.GetComponent<BaseMovement>().Speed /= 2;
        ItemSlot.itemslot1.erasePicture();
    }

    private void ShoesBuff(GameObject gameObject)
    {
        gameObject.GetComponent<BaseMovement>().Speed *= 2;
        ItemSlot.itemslot1.setPicture();
    }
}
