using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//기본 스텟이 상속받을 클래스
public class StatBase : MonoBehaviour
{
    //기본값이 될 수도, 더해지는 값이 될 수도
    //예를 들면 이 클래스를 스텟이 상속 받으면 힘 = 10이 되는 거고, 버프가 상속 받으면 힘 +10이 되는 구조
    protected float m_BaseValue;

    //퍼센트로 증감하는 버프를 위해 만든 멤버변수
    protected float m_BaseMultiplier;

    //초기화를 위한 함수(생성자와 같은 기능)
    public void SetStat(float value, float multiplier = 1)
    {
        m_BaseValue = value;
        m_BaseMultiplier = multiplier;
    }

    //아래 두 개는 get 함수
    public float GetBaseValue()
    {
        return m_BaseValue;
    }

    public float GetBaseMultiplier()
    {
        return m_BaseMultiplier;
    }
}