using System.Collections;
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
    public hMap m_CurMap;

    private void Awake()
    {
        if (m_MapDatabase == null) m_MapDatabase = Resources.Load("MapDatabase") as hMapDatabase;
        if (m_MapDatabase == null)
        {
            Debug.LogError("There is no mapdatabase!");
            return;
        }

        LoadMap(0);
    }

    //맵씬 로드 후 맵 로드
    public void LoadMap(int inMapId, List<Character> inMonsterList = null, bool inIsBoss = false)
    {
        m_CurMap = Instantiate(m_MapDatabase.GetMap(inMapId));
        m_CurMap.enterEvent += EnterEntrance;

        for (int i = 0; i < m_CurMap.entranceList.Length; ++i)
        {
            if(inIsBoss)
            {
                m_CurMap.entranceList[i].SetType(MapType.BOSS);
            }
            else
            {
                MapType type = (MapType)Random.Range(0, (int)MapType.BOSS);
                m_CurMap.entranceList[i].SetType(type);
            }
        }

        if(inMonsterList != null)
            m_CurMap.SetSpawnMonter(inMonsterList);
    }

    private void EnterEntrance(hEntrance inEntrance)
    {
        Debug.Log("enter entrance " + inEntrance.id + " " + inEntrance.nextMapType);
        m_CurMap.SetType(inEntrance.nextMapType);
        //해당 출입구 id를 가지고 다음 맵을 선택
        //먼저 로딩씬으로 전환 후 다음 맵 로딩 후 전환
        //levelmanager에게 해당 leveldata 요청
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_CurMap.SetType((MapType)(((int)m_CurMap.type + 1) % (int)MapType.count));
        }
    }
}
