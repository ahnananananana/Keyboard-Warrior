using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private StatList m_Stat = new StatList();
    
    public StatList Stats()
    {
        return m_Stat;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    

    public void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {

        }
        if (Input.GetKey(KeyCode.S))
        {

        }
        if (Input.GetKey(KeyCode.A))
        {

        }
        if (Input.GetKey(KeyCode.D))
        {

        }
    }
}
