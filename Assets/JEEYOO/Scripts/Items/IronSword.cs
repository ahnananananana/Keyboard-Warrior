using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : Sword
{
    public IronSword()
    {
        m_ID = 1;
    }
       
    void Start()
    {
        m_ID = 1;
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
