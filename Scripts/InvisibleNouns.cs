using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleNouns : MonoBehaviour
{

    public GameObject[] blocks;
    public SpriteRenderer[] blocksRenderer;

    public ChangeCharacter ccNumber;
    public int number;

    void Start()
    {
        blocksRenderer = new SpriteRenderer[blocks.Length];

        for (int i=0; i<blocks.Length;i++)
        {
            blocksRenderer[i] = blocks[i].GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        number = ccNumber.bodiesNumber;
        if (number == 1)
        {
            foreach (var b in blocksRenderer)
            {
                b.enabled = false;
            }
        }
        else 
        {
            foreach (var b in blocksRenderer)
            {
                b.enabled = true;
            }
        }

    }
}
