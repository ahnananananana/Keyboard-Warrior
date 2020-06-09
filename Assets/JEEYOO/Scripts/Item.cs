using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private Stat iStat = new Stat();
    private HP iHP = new HP();

    public HP IHP { get => iHP; set => iHP = value; }
}
