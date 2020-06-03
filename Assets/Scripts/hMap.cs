using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hMap : MonoBehaviour
{
    [SerializeField]
    private MapType m_Type;
    [SerializeField]
    private hEntrance[] m_EntranceList;
    [SerializeField]
    private Transform m_Lights;
    private Light[] m_LightList;

    public event DelEntrance enterEvent;

    [SerializeField]
    private int m_Id;

    public int id { get => m_Id; }
    public MapType type { get => m_Type; set => m_Type = value; }
    public hEntrance[] entranceList { get => m_EntranceList; set => m_EntranceList = value; }

    private void Awake()
    {
        for (int i = 0; i < m_EntranceList.Length; ++i)
        {
            m_EntranceList[i].enterEvent += EnterEntrance;
        }
        m_LightList = m_Lights.GetComponentsInChildren<Light>();

        SetType(m_Type);
    }

    public void SetType(MapType inType)
    {
        m_Type = inType;
        Color lightColor = Color.white;
        switch (m_Type)
        {
            case MapType.NORMAL:
                lightColor = Color.white;
                break;
            case MapType.ELITE:
                lightColor = Color.cyan;
                break;
            case MapType.BOSS:
                lightColor = Color.red;
                break;
            case MapType.BONUS:
                lightColor = Color.yellow;
                break;
        }
        for (int i = 0; i < m_LightList.Length; ++i)
        {
            m_LightList[i].color = lightColor;
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
