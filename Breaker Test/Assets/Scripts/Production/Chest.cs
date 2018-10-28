using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite Empty_Chest;
    public int pesosAmount = 10;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = Empty_Chest;
            Debug.Log("Grant " + pesosAmount + " pesos!");
        }
    }
}
