﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum STATE
    {
        CREATE, ALIVE, DEAD,
    }

    STATE m_state = STATE.ALIVE;
    public int m_ID;
    public string m_Name;

    public Stat m_MaxHP;
    public Stat m_MaxMP;
    public float m_CurrHP;
    public float m_CurrMP;

    public Stat m_Attack;
    public Stat m_Defense;
    public Stat m_Magic;
    public Stat m_Resistance;

    public Stat m_MoveSpeed;
    public Stat m_AttackSpeed;

    public Experience m_EXP;

    private void Start()
    {
        
    }

    public void IncreaseStatByLvUp()
    {
        m_MaxHP.IncreaseBaseValue(1.2f);
        m_MaxMP.IncreaseBaseValue(1.2f);
        m_Attack.IncreaseBaseValue(1.2f);
        m_Defense.IncreaseBaseValue(1.2f);
        m_Magic.IncreaseBaseValue(1.2f);
        m_Resistance.IncreaseBaseValue(1.2f);
        m_MoveSpeed.IncreaseBaseValue(1.05f);
        m_AttackSpeed.IncreaseBaseValue(1.05f);
    }

    public void DealDamage(Character defender)
    {
        defender.m_CurrHP -= (Random.Range(0.95f, 1.05f)*m_Attack.m_CurrentValue - defender.m_Defense.m_CurrentValue);
        if (defender.m_CurrHP <= 0)
        {
            m_EXP.GetExp((Monster)defender);
            defender.ChangeState(STATE.DEAD);
            defender.StateProcess();
        }
    }

    public void ChangeState(STATE s)
    {
        if (m_state == s) return;
        m_state = s;

        switch (s)
        {
            case STATE.CREATE:
                m_state = STATE.ALIVE;
                break;
            case STATE.ALIVE:
                break;
            case STATE.DEAD:
                break;
        }
    }

    public void StateProcess()
    {
        switch (m_state)
        {
            case STATE.CREATE:
                break;
            case STATE.ALIVE:
                break;
            case STATE.DEAD:
                Destroy(this.gameObject);
                break;
        }
    }
}
