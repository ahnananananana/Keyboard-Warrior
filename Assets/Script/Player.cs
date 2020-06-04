using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    Character Alien = new Character();
    // Start is called before the first frame update
    void Start()
    {
        // 아래와 같이 캐릭터의 기본 스텟에 접근 가능
        // Alien.Stats().MaxHP();
        // 아래와 같이 캐릭터의 (버프, 아이템 등으로 인해)보정된 스텟에 접근 가능
        // Alien.Stats().MaxHP().GetFinalValue();
        // 아래와 같이 캐릭터의 스텟에 버프 적용 가능
        // Alien.Stats().Accuracy().AddFinalBuff(버프이름);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
