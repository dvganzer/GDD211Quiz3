using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeHive : Consumable
{
    public override void UseItem()
    {
        base.UseItem();
        Calories -= 20;
        Karmas -= 20;
        playerMessage.text = "Keep us Alive- We Make Food!";
    }
}
