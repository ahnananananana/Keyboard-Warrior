using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hStatUI : MonoBehaviour
{
    private Character m_Player;
    [SerializeField]
    private Transform m_StatContainer;
    private hStatElement[] m_StatUIElementList;

    private void Awake()
    {
        m_StatUIElementList = m_StatContainer.GetComponentsInChildren<hStatElement>();
    }

    public void LoadStatWindow(Character inCharacter)
    {
        m_Player = inCharacter;
        RefreshUI();
    }

    public void RefreshUI()
    {
        //m_StatUIElementList[0].Set("체력", m_Player.)
    }

}
