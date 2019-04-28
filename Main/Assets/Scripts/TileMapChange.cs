using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapChange : MonoBehaviour
{
    public static TileMapChange instance;

    public GameObject TileDeath;
    public GameObject TileLife;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        //ChangeTile();
    }

    public void ChangeTile()
    {
        TileDeath.SetActive(false);
        TileLife.SetActive(true);
    }

    private void OnValidate()
    {
        Debug.Assert(TileDeath != null);
        Debug.Assert(TileLife != null);
    }
}
