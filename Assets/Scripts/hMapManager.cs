using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hMapManager : MonoBehaviour
{
    [SerializeField]
    private hMapDatabase m_MapDatabase;
    [SerializeField]
    private hMap[] m_MapList;

    private hMap m_CurMap;

    private void Awake()
    {
        if (m_MapDatabase == null) m_MapDatabase = Resources.Load("MapDatabase") as hMapDatabase;
        if (m_MapDatabase == null)
        {
            Debug.LogError("There is no mapdatabase!");
            return;
        }

        /*for (int i = 0; i < m_MapDatabase.mapList.Length; ++i)
        {
            m_MapDatabase.mapList[i].enterEvent += EnterEntrance;
        }*/

        m_CurMap = Instantiate(m_MapDatabase.mapList[0]);
        m_CurMap.enterEvent += EnterEntrance;
    }

    private void LoadMap(int inMapId)
    {

    }

    private void EnterEntrance(hEntrance inEntrance)
    {
        Debug.Log("enter entrance");
        //해당 출입구 id를 가지고 다음 맵을 선택
        //먼저 로딩씬으로 전환 후 다음 맵 로딩 후 전환
    }
}
