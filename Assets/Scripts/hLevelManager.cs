using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hLevelManager : MonoBehaviour
{
    [SerializeField]
    private hLevelData[] m_LevelDataList;

    public hLevelData LoadLevel(int inLevel)
    {

        return m_LevelDataList[inLevel];
    }
}
