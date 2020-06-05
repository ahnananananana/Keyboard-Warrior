using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hStatUI : MonoBehaviour
{
    private StatList m_CurStat;
    [SerializeField]
    private Transform m_StatContainer;
    private hStatElement[] m_StatUIElementList;

    private void Awake()
    {
        m_StatUIElementList = m_StatContainer.GetComponentsInChildren<hStatElement>();

    }

    public void LoadStatWindow(StatList inStat)
    {
        m_CurStat = inStat;
        RefreshUI();
    }

    public void RefreshUI()
    {

    }

}
