using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Consumable
{
    public override void UseItem()
    {
        base.UseItem();
        Calories += 5;
        Karmas += 10;
        playerMessage.text = "Good for Teeth";
    }
}
