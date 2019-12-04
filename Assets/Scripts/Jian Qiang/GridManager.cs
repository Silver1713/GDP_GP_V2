using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int height = 10;
    public int length = 10;
    public float tileSize = 1;
    // Start is called before the first frame update
    void Start()
    {
        grid();
    }

    void grid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("path1"));
        for (int y = 0; y < height; y++)
        {
            for(int x = 0; x< length; x++)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = x * tileSize;
                float posY = y * tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }

        Destroy(referenceTile);

        float gridLength = length * tileSize;
        float gridHeight = height * tileSize;
        //transform.position = new Vector2(-gridLength / 2 + tileSize / 2, gridHeight / 2 - tileSize - 2);
    }
}


