using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : Sword
{
    void Start()
    {
        m_ID = 1;
        m_Name = "IronSword";
    }
    public override void Equip(Character c)
    {
        c.m_Attack.AddModifier(new StatModifier(10, StatModType.Flat, this));
    }

    public override void UnEquip(Character c)
    {
        c.m_Attack.RemoveAllModFromSource(this);
    }
}
