using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hPlayerUI : MonoBehaviour
{
    [SerializeField]
    private Character m_Player;
    [SerializeField]
    private hStatWindow m_StatWindow;
    [SerializeField]
    private hBattleWindow m_BattleWindow;

    private void Start()
    {
        //m_Player.InitializeBaseValue(1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f, 0f, 1f, 2f, 3f, 4f, 1f);
        m_StatWindow.Init(m_Player);
        m_StatWindow.SetWindow(false);

        m_BattleWindow.Init(m_Player);
    }

    public void Init(Player inPlayer)
    {
        m_Player = m_Player;
    }

    public void ShowStatWindow()
    {
        if (!m_StatWindow.isActive)
            m_StatWindow.SetWindow(true);
        else
            m_StatWindow.SetWindow(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!m_StatWindow.isActive)
                m_StatWindow.SetWindow(true);
            else
                m_StatWindow.SetWindow(false);
        }

    }

    public void RefreshUI()
    { }

}
