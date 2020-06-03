﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="Resources/LevelData/NewLevelData")]
public class hLevelData : ScriptableObject
{
    [SerializeField]
    private bool m_IsBoss;
    [SerializeField]
    private Character[] m_MonsterList;
    //나올 수 있는 버프리스트

    public bool isBoss { get => m_IsBoss; }
    public Character[] monsterList { get => m_MonsterList; }
}
