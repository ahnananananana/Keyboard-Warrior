using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Magic.BaseValue = 10;
            player.Magic.AddRawBuff(player.RawBuff.add10);
            Debug.Log(player.Magic.FinalValue);
        }
    }
}
