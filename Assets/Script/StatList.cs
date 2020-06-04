using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스텟목록
public class StatList : StatManager
{
    //순서대로 최대체력, 최대마나, 현재체력, 현재마나
    private StatManager m_MaxHP;
    private StatManager m_MaxMP;
    private StatManager m_HP;
    private StatManager m_MP;

    //순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
    private StatManager m_Strength;
    private StatManager m_Magic;
    private StatManager m_PhysicalAtk;
    private StatManager m_MagicAtk;
    private StatManager m_Defense;
    private StatManager m_Resistance;

    //순서대로 회피, 적중률, 크리확률, 크리배수
    private StatManager m_Evade;
    private StatManager m_Accuracy;
    private StatManager m_CritChance;
    private StatManager m_CritMultiplier;

    private StatManager m_MoveSpeed;
    private StatManager m_EXP;
    private StatManager m_Level;

    //각 스텟에 접근해서 setStat하기 위한 get 함수들
    public StatManager MaxHP()           { return m_MaxHP; }
    public StatManager MaxMP()           { return m_MaxMP; }
    public StatManager HP()              { return m_HP; }
    public StatManager MP()              { return m_MP; }

    public StatManager Strength()        { return m_Strength; }
    public StatManager Magic()           { return m_Magic; }
    public StatManager PhysicalAtk()     { return m_PhysicalAtk; }
    public StatManager MagicAtk()        { return m_MagicAtk; }
    public StatManager Defense()         { return m_Defense; }
    public StatManager Resistance()      { return m_Resistance; }

    public StatManager Evade()           { return m_Evade; }
    public StatManager Accuracy()        { return m_Accuracy; }
    public StatManager CritChance()      { return m_CritChance; }
    public StatManager CritMultiplier()  { return m_CritMultiplier; }

    public StatManager MoveSpeed()       { return m_MoveSpeed; }
    public StatManager EXP()             { return m_EXP; }
    public StatManager Level()           { return m_Level; }
}
