using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData
{
    public List<Item> L_ItemList = new List<Item>();
    public Item[] Data_Item;

    void Start()
    {
        Data_Item = Resources.LoadAll<Item>("Prefabs");
    }


}
