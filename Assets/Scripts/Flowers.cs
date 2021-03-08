using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : Consumable
{
    public override void UseItem()
    {
        base.UseItem();
        Calories += 2;
        Karmas += 10;
        playerMessage.text = "Medicinal in Small Quantities";
    }
}
