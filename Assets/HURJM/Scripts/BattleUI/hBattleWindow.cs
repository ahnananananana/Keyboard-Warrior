using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hBattleWindow : MonoBehaviour
{
    private Character m_Player;//Delegate 등록용 혹은 그외 수치 받아오는 용
    [SerializeField]
    private hStatBar m_HealthBar, m_ManaBar, m_ExpBar;
    [SerializeField]
    private hStatusContainer m_StatusContainer;

    public void Init(Character inPlayer)
    {
        m_Player = inPlayer;
        m_HealthBar.SetMax(inPlayer.MaxHP.FinalValue);
        m_HealthBar.SetValue(inPlayer.HP.FinalValue);
        m_ManaBar.SetMax(inPlayer.MaxMP.FinalValue);
        m_ManaBar.SetValue(inPlayer.MP.FinalValue);

        m_ExpBar.SetMax(inPlayer.EXP.FinalValue);
        m_ExpBar.SetValue(0);//현재 경험치 테이블이 필요
    }

}
