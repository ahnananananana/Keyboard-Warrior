﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MapType
{
    NORMAL,
    ELITE,
    BONUS,
    BOSS,
    count,
}

public class hMapManager : MonoBehaviour
{
    [SerializeField]
    private hMapDatabase m_MapDatabase;
    [SerializeField]
    private hMap m_Map;
    [SerializeField]
    private Transform m_MapPos;

    private void Awake()
    {
        if (m_MapDatabase == null) m_MapDatabase = Resources.Load("MapDatabase") as hMapDatabase;
        if (m_MapDatabase == null)
        {
            Debug.LogError("There is no mapdatabase!");
            return;
        }

        m_Map.enterEvent += EnterEntrance;

    }

    private void Start()
    {
        LoadMap();
    }

    //맵씬 로드 후 맵 로드
    public void LoadMap()
    {
        hLevelData levelData = hLevelManager.current.LoadNextLevel();

        for (int i = 0; i < m_Map.entranceList.Length; ++i)
        {
            if(levelData.isBoss)
            {
                m_Map.entranceList[i].SetType(MapType.BOSS);
            }
            else
            {
                MapType type = (MapType)Random.Range(0, (int)MapType.BOSS);
                m_Map.entranceList[i].SetType(type);
            }
        }
            
        m_Map.SetSpawnMonster(levelData.monsterList);

        m_Map.StartMap();
    }

    private void EnterEntrance(hEntrance inEntrance)
    {
        Debug.Log("enter entrance " + inEntrance.id + " " + inEntrance.nextMapType);
        hLevelManager.current.curLevel++;
        SceneLoad.I.SceneChange(2);
        //해당 출입구 id를 가지고 다음 맵을 선택
        //먼저 로딩씬으로 전환 후 다음 맵 로딩 후 전환
        //levelmanager에게 해당 leveldata 요청
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Map.SetType((MapType)(((int)m_Map.type + 1) % (int)MapType.count));
        }
    }
}
