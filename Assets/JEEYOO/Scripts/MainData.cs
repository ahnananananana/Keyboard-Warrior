using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ITEMID
{
    BRONZESWORD,  // == 0, 따로 sort하지 않아도 되도록 파일명도 00Ironsword으로
    FIRESWORD,  // == 1, 따로 sort하지 않아도 되도록 파일명도 01firesword으로
}

public class MainData : MonoBehaviour
{
    public Item[] ItemData;
    public Buff[] BuffData;
    public Monster[] MonsterData;
    public hLevelData[] LevelData;

    // Start is called before the first frame update
    void Start()
    {
        ItemData = Resources.LoadAll<Item>("Prefabs");
        BuffData = Resources.LoadAll<Buff>("Prefabs");
        MonsterData = Resources.LoadAll<Monster>("Prefabs");
        LevelData = Resources.LoadAll<hLevelData>("LevelData");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
