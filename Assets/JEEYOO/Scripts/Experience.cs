﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    public int m_Level = 1;
    public int m_CurrExp = 0;
    public int m_TotalExp = 0;
    public float m_BaseExp = 100;
    public float m_ExpModifier = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetExp(Monster m)
    {
        m_TotalExp += m.EXP;
        m_CurrExp += m.EXP;
        if(m_CurrExp >= m_BaseExp)
        {
            LevelUp();
            m_CurrExp = 0;
        }
    }

    public void LevelUp()
    {
        m_Level++;
        m_BaseExp *= m_ExpModifier;
    }
}
