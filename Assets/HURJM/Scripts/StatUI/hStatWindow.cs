using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hStatWindow : MonoBehaviour
{
    private Character m_Player;//Delegate 등록용 혹은 그외 수치 받아오는 용
    [SerializeField]
    private Transform m_StatContainer;
    [SerializeField]
    private Transform m_EquipmentContainer;

    private hStatElement[] m_StatUIElementList;
    private hEquipmentSlot[] m_EquipmentSlotList;

    public bool isActive => gameObject.activeSelf;

    private void Awake()
    {
        Debug.Log("test");
        m_StatUIElementList = m_StatContainer.GetComponentsInChildren<hStatElement>();
        m_EquipmentSlotList = m_EquipmentContainer.GetComponentsInChildren<hEquipmentSlot>();
    }

    public void Init(Character inPlayer)
    {
        m_Player = inPlayer;
        RefreshStatUI();
    }
    public void SetWindow(bool inSet) => gameObject.SetActive(inSet);

    public void RefreshStatUI()
    {
        //m_StatUIElementList[0].Set("레벨", m_Player.Level.FinalValue.ToString());
        //m_StatUIElementList[1].Set("체력", m_Player.MaxHP.FinalValue.ToString());
        //m_StatUIElementList[2].Set("마나", m_Player.MaxMP.FinalValue.ToString());
        //m_StatUIElementList[3].Set("힘", m_Player.Strength.FinalValue.ToString());
        //m_StatUIElementList[4].Set("마법", m_Player.Magic.FinalValue.ToString());
        //m_StatUIElementList[5].Set("물리공격력", m_Player.PhysicalAtk.FinalValue.ToString());
        //m_StatUIElementList[6].Set("마법공격력", m_Player.MagicAtk.FinalValue.ToString());
        //m_StatUIElementList[7].Set("방어력", m_Player.Defense.FinalValue.ToString());
        //m_StatUIElementList[8].Set("저항", m_Player.Resistance.FinalValue.ToString());
        //m_StatUIElementList[9].Set("회피율", m_Player.Evade.FinalValue.ToString());
        //m_StatUIElementList[10].Set("정확도", m_Player.Accuracy.FinalValue.ToString());
        //m_StatUIElementList[11].Set("치명타확률", m_Player.CritChance.FinalValue.ToString());
        //m_StatUIElementList[12].Set("이동속도", m_Player.MoveSpeed.FinalValue.ToString());
    }
}
