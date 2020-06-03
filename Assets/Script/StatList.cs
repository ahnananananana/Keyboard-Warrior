using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스텟목록
public class StatList : StatManager
{
    //순서대로 최대체력, 최대마나, 현재체력, 현재마나
    protected StatManager m_MaxHP;
    protected StatManager m_MaxMP;
    protected StatManager m_HP;
    protected StatManager m_MP;

    //순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
    protected StatManager m_Strength;
    protected StatManager m_Magic;
    protected StatManager m_PhysicalAtk;
    protected StatManager m_MagicAtk;
    protected StatManager m_Defense;
    protected StatManager m_Resistance;

    //순서대로 회피, 적중률, 크리확률, 크리배수
    protected StatManager m_Evade;
    protected StatManager m_Accuracy;
    protected StatManager m_CritChance;
    protected StatManager m_CritMultiplier;

    protected StatManager m_MoveSpeed;
    protected StatManager m_EXP;
    protected StatManager m_Level;
}
