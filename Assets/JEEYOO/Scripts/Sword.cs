using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Item
{
    public void Equip(Character c)
    {
        c.m_MaxHP.AddModifier(new StatModifier(10, StatModType.Flat, this));
    }

    public void UnEquip(Character c)
    {
        c.m_MaxHP.RemoveAllModFromSource(this);
    }
}