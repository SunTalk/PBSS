using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "HeartItem", menuName = "Item/Heart")]

[System.Serializable]
public class PropHeart : PropScriptObject
{
    public override void Use(GameObject gameObject)
    {
        base.Use(gameObject);
        //Debug.Log("PropHeartScriptObject");
        gameObject.GetComponent<Health>().Heal(1);
    }
}
