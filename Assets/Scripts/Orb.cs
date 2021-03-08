using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : Consumable
{
    public override void UseItem()
    {
        base.UseItem();
        Calories += 50;
        Karmas += 50;
        playerMessage.text = "Optimal Food Source!";

    }
}
