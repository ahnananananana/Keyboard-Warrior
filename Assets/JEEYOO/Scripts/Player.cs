using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField]
    private hPlayerUI playerUI;
    
    // Start is called before the first frame update
    void Start()
    {
        playerUI.Init(this);
        MaxHP.changeEvent += playerUI.RefreshUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
