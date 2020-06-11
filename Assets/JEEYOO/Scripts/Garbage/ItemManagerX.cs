using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager
{
    Item item = new Item();

    public void EquipSword(Character character)
    {
        character.HP.AddItemStat(item.Add(10, 0));
        character.Strength.AddItemStat(sword.Str20);
    }

    public void UnEquipSword(Character character, Item item)
    {
        character.HP.RemoveItemStat(sword.Hp20);
        character.Strength.RemoveItemStat(sword.Str20);
    }
}
