using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected MaxHP m_MaxHP;
    protected MaxMP m_MaxMP;
    protected HP m_HP;
    protected MP m_MP;

    //순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
    protected Strength m_Strength;
    protected Magic m_Magic;
    protected PhysicalAtk m_PhysicalAtk;
    protected MagicAtk m_MagicAtk;
    protected Defense m_Defense;
    protected Resistance m_Resistance;

    //순서대로 회피, 적중률, 크리확률, 크리배수
    protected Evade m_Evade;
    protected Accuracy m_Accuracy;
    protected CritChance m_CritChance;
    protected CritMultiplier m_CritMultiplier;

    protected MoveSpeed m_MoveSpeed;
    protected EXP m_EXP;
    protected Level m_Level;

    protected void InitializeBaseValue
        (float maxhp, float maxmp, float hp, float mp,
        float str, float mag, float physatk, float magatk, float def, float res,
        float eva, float acc, float critchance, float critmult,
        float spd, float exp, float lev)
    {
        m_MaxHP.BaseValue = maxhp;
        m_MaxMP.BaseValue = maxmp;
        m_HP.BaseValue = hp;
        m_MP.BaseValue = mp;
        m_Strength.BaseValue = str;
        m_Magic.BaseValue = mag;
        m_PhysicalAtk.BaseValue = physatk;
        m_MagicAtk.BaseValue = magatk;
        m_Defense.BaseValue = def;
        m_Resistance.BaseValue = res;
        m_Evade.BaseValue = eva;
        m_Accuracy.BaseValue = acc;
        m_CritChance.BaseValue = critchance;
        m_CritMultiplier.BaseValue = critmult;
        m_MoveSpeed.BaseValue = spd;
        m_EXP.BaseValue = exp;
        m_Level.BaseValue = lev;
    }

    public void PhysicalAttack(Character attacker, Character defender)
    {
        defender.m_HP.FinalValue -= (attacker.m_PhysicalAtk.FinalValue - defender.m_Defense.FinalValue);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {

        }
        if (Input.GetKey(KeyCode.S))
        {

        }
        if (Input.GetKey(KeyCode.A))
        {

        }
        if (Input.GetKey(KeyCode.D))
        {

        }
    }
}
