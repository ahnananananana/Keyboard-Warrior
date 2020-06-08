using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Player player;
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
            player.Magic.AddRawBuff(player.Add10);
            Debug.Log(player.Magic.FinalValue);
        }
    }
}
