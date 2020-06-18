using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSword : Sword
{
    public FireSword()
    {
        m_ID = 2;
    }
    private void Start()
    {
        m_ID = 2;
    }
    public override void Equip(Character c)
    {
        c.m_Attack.AddModifier(new StatModifier(20, StatModType.Flat, this));
    }

    public override void UnEquip(Character c)
    {
        c.m_Attack.RemoveAllModFromSource(this);
    }
}
