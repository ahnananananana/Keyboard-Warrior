using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Player player;
    RawBuffList rawBuffList = new RawBuffList();
    FinalBuffList finalBuffList = new FinalBuffList();
    Sword sword = new Sword();

    // Start is called before the first frame update
    void Start()
    {
        player.InitializeBaseValue(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Magic.BaseValue = 10;
            player.Magic.AddRawBuff(rawBuffList.Add10);
            player.Magic.AddFinalBuff(finalBuffList.Percent10);
            Debug.Log(player.Magic.FinalValue);
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (!player.Magic.isRawEmpty())
            { player.Magic.RemoveRawBuff(rawBuffList.Add10); }
            Debug.Log(player.Magic.FinalValue);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            player.HP.BaseValue += sword.IHP.BaseValue;
        }
    }
}
