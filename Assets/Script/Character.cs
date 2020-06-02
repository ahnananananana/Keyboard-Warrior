using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float m_HP;
    private float m_MP;

    //순서대로 물리공격력, 마법공격력, 물리방어, 마법방어
    private float m_PhysicalAtk;
    private float m_MagicAtk;
    private float m_Defense;
    private float m_Resistance;
    
    //순서대로 회피, 적중률, 크리확률, 크리배수
    private float m_Evade;
    private float m_Accuracy;
    private float m_CritChance;
    private float m_CritMultiplier;

    private float m_MoveSpeed;
    private float m_EXP;
    private float m_Level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
