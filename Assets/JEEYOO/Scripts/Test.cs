using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Player player;
    public Monster monster;
    private MainData m_MainData;
    
    public Item[] allPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        m_MainData.ItemData[(int)ITEMID.IRONSWORD].Equip(player);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.m_Attack.IncreaseBaseValue();
            Debug.Log(player.m_Attack.m_BaseValue);
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            allPrefabs = Resources.LoadAll<Item>("Prefabs");
            for (int i = 0; i < allPrefabs.Length; i++)
            {
                Debug.Log(allPrefabs[i].m_ID);
                Debug.Log(allPrefabs[i].m_ItemName);
            }

            Debug.Log(player.m_Attack.m_CurrentValue);
            allPrefabs[0].Equip(player);
            Debug.Log(player.m_Attack.m_CurrentValue);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Debug.Log(player.m_Attack.m_CurrentValue);
            allPrefabs[0].UnEquip(player);
            Debug.Log(player.m_Attack.m_CurrentValue);
        }
    }
}
