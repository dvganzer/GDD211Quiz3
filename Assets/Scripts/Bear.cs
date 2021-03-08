using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bear : Consumable
{
    public override void UseItem()
    {
        base.UseItem();
        Calories += 200;
        Karmas -= 20;
        playerMessage.text = "You Hurts Me";
    }
}
