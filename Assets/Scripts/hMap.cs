using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hMap : MonoBehaviour
{
    [SerializeField]
    private hEntrance[] m_EntranceList;

    public event DelEntrance enterEvent;

    [SerializeField]
    private int m_Id;

    public int id { get => m_Id; }

    private void Awake()
    {
        for (int i = 0; i < m_EntranceList.Length; ++i)
        {
            m_EntranceList[i].enterEvent += EnterEntrance;
        }
    }

    private void EnterEntrance(hEntrance inEntrance)
    {
        enterEvent?.Invoke(inEntrance);
    }

    public void ClearEvent()
    {
        enterEvent = null;
    }
}
