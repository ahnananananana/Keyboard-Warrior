using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//버프가 적용 된 스텟을 산출하기 위한 클래스. 스텟이 상속 받음
public class StatManager : StatBase
{
    //여러 버프를 담을 수 있는 List생성.
    protected List<RawBuff> L_RawBuffs = new List<RawBuff>();
    protected List<FinalBuff> L_FinalBuffs = new List<FinalBuff>();

    //스텟값을 직접 건드리지 않기 위해 선언하는, temp 기능을 하는 멤버변수
    private float m_FinalValue;
    
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
        m_FinalValue = GetBaseValue();

        float RawBuffValue = 0;
        float RawBuffMultiplier = 0;

        foreach(RawBuff buff in L_RawBuffs)
        {
            RawBuffValue += buff.GetBaseValue();
            RawBuffMultiplier += buff.GetBaseMultiplier();
        }

        m_FinalValue += RawBuffValue;
        m_FinalValue *= (1 + RawBuffMultiplier);
    }

    //FinalBuff를 갱신하는 함수
    public void RefreshFinalBuff()
    {
        m_FinalValue = GetBaseValue();

        float FinalBuffValue = 0;
        float FinalBuffMultiplier = 0;

        foreach (FinalBuff buff in L_FinalBuffs)
        {
            FinalBuffValue += buff.GetBaseValue();
            FinalBuffMultiplier += buff.GetBaseMultiplier();
        }

        m_FinalValue += FinalBuffValue;
        m_FinalValue *= (1 + FinalBuffMultiplier);
    }

    public float GetFinalValue()
    {
        return m_FinalValue;
    }
    

    //추가해야 할 것 : 포션이나 피격 등으로 체력, 마나 등 증감시키는 함수 -> 이것도 그냥 있는 함수로 쓸까?
}
