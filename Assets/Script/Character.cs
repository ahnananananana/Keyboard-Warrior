using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{


    protected float m_HP;
    protected float m_MP;

    //순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
    protected float m_Strength;
    protected float m_Magic;
    protected float m_PhysicalAtk;
    protected float m_MagicAtk;
    protected float m_Defense;
    protected float m_Resistance;

    //순서대로 회피, 적중률, 크리확률, 크리배수
    protected float m_Evade;
    protected float m_Accuracy;
    protected float m_CritChance;
    protected float m_CritMultiplier;

    protected float m_MoveSpeed;
    protected float m_EXP;
    protected float m_Level;
    

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
