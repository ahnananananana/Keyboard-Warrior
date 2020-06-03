using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//버프가 적용 된 스텟을 산출하기 위한 클래스. 스텟이 상속 받음
public class Attribute : BaseAttribute
{
    //여러 버프를 담을 수 있는 List생성.
    protected List<RawBonus> _rawBonuses = new List<RawBonus>();
    protected List<FinalBonus> _finalBonuses = new List<FinalBonus>();

    //스텟값을 직접 건드리지 않기 위해 선언하는 temp 기능을 하는 멤버변수
    protected float _finalValue;

    //초기화를 위함 함수(생성자처럼 기능)
    public void setAttribute()
    {

    }
    
    //위에 선언한 List에 버프를 담는 함수
    public void addRawBonus(RawBonus bonus)
    {
        
    }

    public void addFinalBonus(FinalBonus bonus)
    {

    }

    //버프가 해제될 때 List에서 해당 버프를 제거하기 위한 함수
    public void removeRawBonus(RawBonus bonus)
    {

    }

    public void removeFinalBonus(FinalBonus bonus)
    {

    }

    //최종적으로 버프를 모두 계산하여 _finalValue에 담는 함수
    public float calculateValue()
    {
        _finalValue = baseValue();

        float rawBonusValue = 0;
        float rawBonusMultiplier = 0;

        foreach(RawBonus bonus in _rawBonuses)
        {
            rawBonusValue += bonus.baseValue();
            rawBonusMultiplier += bonus.baseMultiplier();
        }

        _finalValue += rawBonusValue;
        _finalValue *= (1 + rawBonusMultiplier);

        float finalBonusValue = 0;
        float finalBonusMultiplier = 0;

        foreach (FinalBonus bonus in _finalBonuses)
        {
            finalBonusValue += bonus.baseValue();
            finalBonusMultiplier += bonus.baseMultiplier();
        }

        _finalValue += finalBonusValue;
        _finalValue *= (1 + finalBonusMultiplier);

        return _finalValue;
    }

    //finalValue를 get하는 함수
    public float finalValue()
    {
        return calculateValue();
    }
}
