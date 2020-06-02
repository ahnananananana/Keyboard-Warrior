using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void DelEntrance(hEntrance inEntrance);

public class hEntrance : MonoBehaviour
{
    public event DelEntrance enterEvent;
    [SerializeField]
    private LayerMask m_PlayerLayer;

    [SerializeField]
    private int m_Id;

    public int id { get => m_Id; }

    private void OnTriggerEnter(Collider other)
    {
        if(1  << other.gameObject.layer == m_PlayerLayer)
        {
            enterEvent?.Invoke(this);
        }
    }
}
