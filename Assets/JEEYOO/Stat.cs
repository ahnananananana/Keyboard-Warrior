using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//버프가 적용 된 스텟을 산출하기 위한 클래스. 스텟이 상속 받음
public class Stat : StatBase
{
    //여러 버프를 담을 수 있는 List생성.
    private List<RawBuff> L_RawBuffs = new List<RawBuff>();
    private List<FinalBuff> L_FinalBuffs = new List<FinalBuff>();

    //스텟값을 직접 건드리지 않기 위해 선언하는, temp 기능을 하는 멤버변수
    private float m_FinalValue;

    public float FinalValue { get => m_FinalValue + BaseValue; set => m_FinalValue = value; }

    //위에 선언한 List에 버프를 담는 함수
    public void AddRawBuff(RawBuff buff)
    {
        L_RawBuffs.Add(buff);
        RefreshRawBuff();
    }

    public void AddFinalBuff(FinalBuff buff)
    {
        L_FinalBuffs.Add(buff);
        RefreshFinalBuff();
    }

    //버프가 해제될 때 List에서 해당 버프를 제거하기 위한 함수
    public void RemoveRawBuff(RawBuff buff)
    {
        L_RawBuffs.Remove(buff);
        RefreshRawBuff();
    }

    public void RemoveFinalBuff(FinalBuff buff)
    {
        L_FinalBuffs.Remove(buff);
        RefreshFinalBuff();
    }

    //RawBuff를 갱신하는 함수
    public void RefreshRawBuff()
    {
        FinalValue = BaseValue;

        float RawBuffValue = 0;
        float RawBuffMultiplier = 0;

        foreach(RawBuff buff in L_RawBuffs)
        {
            RawBuffValue += buff.BaseValue;
            RawBuffMultiplier += buff.BaseMultiplier;
        }

        FinalValue += RawBuffValue;
        FinalValue *= (1 + RawBuffMultiplier);
    }

    //FinalBuff를 갱신하는 함수
    public void RefreshFinalBuff()
    {
        FinalValue = BaseValue;

        float FinalBuffValue = 0;
        float FinalBuffMultiplier = 0;

        foreach (FinalBuff buff in L_FinalBuffs)
        {
            FinalBuffValue += buff.BaseValue;
            FinalBuffMultiplier += buff.BaseMultiplier;
        }

        FinalValue += FinalBuffValue;
        FinalValue *= (1 + FinalBuffMultiplier);
    }

    //경험치, 레벨 증감 / 포션으로 인한 체력/마나 증감 구현용
    public void IncreaseStat(float number)
    {
        FinalValue += number;
    }

    

    //추가해야 할 것 : 포션이나 피격 등으로 체력, 마나 등 증감시키는 함수 -> 이것도 그냥 있는 함수로 쓸까?
    //상위 스텟에 영향 받는 스텟(ex. 공격력은 힘의 영향을 받음)들은 코드 수정, 체력은 임시 변수로 행동할(?) 멤버 변수를 추가
}
