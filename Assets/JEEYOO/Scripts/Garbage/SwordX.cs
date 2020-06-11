using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Item
{
    RawBuff hp20 = new RawBuff(20, 0);
    RawBuff str20 = new RawBuff(20, 0);

    public RawBuff Hp20 { get => hp20;}
    public RawBuff Str20 { get => str20; }
}
