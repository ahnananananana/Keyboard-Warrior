using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//먼저 적용되는 버프를 위한 클래스. BaseAttribute를 상속 받음
public class RawBonus : BaseAttribute
{
    //초기화를 위한 함수(생성자와 같은 기능)
    public void setRawBonus(float value = 0, float multiplier = 0)
    {
        _baseValue = value;
        _baseMultiplier = multiplier;
    }

    private void Start()
    {
        setRawBonus();
    }
}
