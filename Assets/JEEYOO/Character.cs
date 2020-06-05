using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private RawBuff m_RawBuff;
    private FinalBuff m_FinalBuff;

    private MaxHP maxHP;
    private MaxMP maxMP;
    private HP hP;
    private MP mP;

    //순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
    private Strength strength;
    private Magic magic;
    private PhysicalAtk physicalAtk;
    private MagicAtk magicAtk;
    private Defense defense;
    private Resistance resistance;

    //순서대로 회피, 적중률, 크리확률, 크리배수
    private Evade evade;
    private Accuracy accuracy;
    private CritChance critChance;
    private CritMultiplier critMultiplier;

    private MoveSpeed moveSpeed;
    private EXP eXP;
    private Level level;

    public MaxHP MaxHP { get => maxHP;}
    public MaxMP MaxMP { get => maxMP;}
    public HP HP { get => hP;}
    public MP MP { get => mP;}
    public Strength Strength { get => strength;}
    public Magic Magic { get => magic;}
    public PhysicalAtk PhysicalAtk { get => physicalAtk;}
    public MagicAtk MagicAtk { get => magicAtk;}
    public Defense Defense { get => defense;}
    public Resistance Resistance { get => resistance;}
    public Evade Evade { get => evade;}
    public Accuracy Accuracy { get => accuracy;}
    public CritChance CritChance { get => critChance;}
    public CritMultiplier CritMultiplier { get => critMultiplier;}
    public MoveSpeed MoveSpeed { get => moveSpeed;}
    public EXP EXP { get => eXP;}
    public Level Level { get => level;}
    public RawBuff RawBuff { get => m_RawBuff; set => m_RawBuff = value; }
    public FinalBuff FinalBuff { get => m_FinalBuff; set => m_FinalBuff = value; }

    public void InitializeBaseValue
        (float maxhp, float maxmp,
        float str, float mag, float physatk, float magatk, float def, float res,
        float eva, float acc, float critchance, float critmult,
        float spd, float exp, float lev)
    {
        MaxHP.BaseValue = maxhp;
        MaxMP.BaseValue = maxmp;
        HP.BaseValue = MaxHP.BaseValue;
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
