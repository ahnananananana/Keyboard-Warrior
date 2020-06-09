﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private MaxHP maxHP = new MaxHP();
    private MaxMP maxMP = new MaxMP();
    private HP hP = new HP();
    private MP mP = new MP();

    //순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
    private Strength strength = new Strength();
    private Magic magic = new Magic();
    private PhysicalAtk physicalAtk = new PhysicalAtk();
    private MagicAtk magicAtk = new MagicAtk();
    private Defense defense = new Defense();
    private Resistance resistance = new Resistance();

    //순서대로 회피, 적중률, 크리확률, 크리배수
    private Evade evade = new Evade();
    private Accuracy accuracy = new Accuracy();
    private CritChance critChance = new CritChance();
    private CritMultiplier critMultiplier = new CritMultiplier();

    private MoveSpeed moveSpeed = new MoveSpeed();
    private EXP eXP = new EXP();
    private Level level = new Level();

    public MaxHP MaxHP { get => maxHP; }
    public MaxMP MaxMP { get => maxMP; }
    public HP HP { get => hP; }
    public MP MP { get => mP; }
    public Strength Strength { get => strength; }
    public Magic Magic { get => magic; }
    public PhysicalAtk PhysicalAtk { get => physicalAtk; }
    public MagicAtk MagicAtk { get => magicAtk; }
    public Defense Defense { get => defense; }
    public Resistance Resistance { get => resistance; }
    public Evade Evade { get => evade; }
    public Accuracy Accuracy { get => accuracy; }
    public CritChance CritChance { get => critChance; }
    public CritMultiplier CritMultiplier { get => critMultiplier; }
    public MoveSpeed MoveSpeed { get => moveSpeed; }
    public EXP EXP { get => eXP; }
    public Level Level { get => level; }

    public void InitializeBaseValue
        (float maxhp, float maxmp,
        float str, float mag, float physatk, float magatk, float def, float res,
        float eva, float acc, float critchance, float critmult,
        float spd, float exp, float lev)
    {
        MaxHP.BaseValue = maxhp;
        MaxMP.BaseValue = maxmp;
        HP.BaseValue = MaxHP.BaseValue / 2f;
        MP.BaseValue = MaxMP.BaseValue;
        Strength.BaseValue = str;
        Magic.BaseValue = mag;
        PhysicalAtk.BaseValue = physatk;
        MagicAtk.BaseValue = magatk;
        Defense.BaseValue = def;
        Resistance.BaseValue = res;
        Evade.BaseValue = eva;
        Accuracy.BaseValue = acc;
        CritChance.BaseValue = critchance;
        CritMultiplier.BaseValue = critmult;
        MoveSpeed.BaseValue = spd;
        EXP.BaseValue = exp;
        Level.BaseValue = lev;
    }

    public void PhysicalAttack(Character attacker, Character defender)
    {
        defender.HP.FinalValue -= (attacker.PhysicalAtk.FinalValue - defender.Defense.FinalValue);
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