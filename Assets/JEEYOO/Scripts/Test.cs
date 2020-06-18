using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jTest : MonoBehaviour
{
    public Player player;
    public Monster monster;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(monster.m_CurrHP);
        MainData.mainData.ItemData[0].Equip(player);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            player.DealDamage(monster);
            Debug.Log(player.m_Attack.m_CurrentValue);
            Debug.Log(monster.m_CurrHP);
            Debug.Log(player.m_EXP.m_Level);
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            
        }
    }
}
