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

    public StatManager MaxHP { get => m_MaxHP; set => m_MaxHP = value; }
    public StatManager MaxMP { get => m_MaxMP; set => m_MaxMP = value; }
    public StatManager HP { get => m_HP; set => m_HP = value; }
    public StatManager MP { get => m_MP; set => m_MP = value; }
    public StatManager Strength { get => m_Strength; set => m_Strength = value; }
    public StatManager Magic { get => m_Magic; set => m_Magic = value; }
    public StatManager PhysicalAtk { get => m_PhysicalAtk; set => m_PhysicalAtk = value; }
    public StatManager MagicAtk { get => m_MagicAtk; set => m_MagicAtk = value; }
    public StatManager Defense { get => m_Defense; set => m_Defense = value; }
    public StatManager Resistance { get => m_Resistance; set => m_Resistance = value; }
    public StatManager Evade { get => m_Evade; set => m_Evade = value; }
    public StatManager Accuracy { get => m_Accuracy; set => m_Accuracy = value; }
    public StatManager CritChance { get => m_CritChance; set => m_CritChance = value; }
    public StatManager CritMultiplier { get => m_CritMultiplier; set => m_CritMultiplier = value; }
    public StatManager MoveSpeed { get => m_MoveSpeed; set => m_MoveSpeed = value; }
    public StatManager EXP { get => m_EXP; set => m_EXP = value; }
    public StatManager Level { get => m_Level; set => m_Level = value; }

    //각 스텟에 접근해서 setStat하기 위한 get 함수들

}
