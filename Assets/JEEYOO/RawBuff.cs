using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RawBuff : Stat
{
    public Add10_Raw add10;
    public Add20_Raw add20;
    public Add30_Raw add30;
    public Add40_Raw add40;
    public Add50_Raw add50;
    public Add100_Raw add100;
    public Add150_Raw add150;

    public Multi001_Raw multi001;
    public Multi002_Raw multi002;
    public Multi003_Raw multi003;
    public Multi004_Raw multi004;
    public Multi005_Raw multi005;
}

public class Add10_Raw : RawBuff { public Add10_Raw() { BaseValue = 10; } }
public class Add20_Raw : RawBuff { public Add20_Raw() { BaseValue = 20; } }
public class Add30_Raw : RawBuff { public Add30_Raw() { BaseValue = 30; } }
public class Add40_Raw : RawBuff { public Add40_Raw() { BaseValue = 40; } }
public class Add50_Raw : RawBuff { public Add50_Raw() { BaseValue = 50; } }
public class Add100_Raw : RawBuff { public Add100_Raw() { BaseValue = 100; } }
public class Add150_Raw : RawBuff { public Add150_Raw() { BaseValue = 150; } }

public class Multi001_Raw : RawBuff { public Multi001_Raw() { BaseMultiplier = 0.01f; } }
public class Multi002_Raw : RawBuff { public Multi002_Raw() { BaseMultiplier = 0.02f; } }
public class Multi003_Raw : RawBuff { public Multi003_Raw() { BaseMultiplier = 0.03f; } }
public class Multi004_Raw : RawBuff { public Multi004_Raw() { BaseMultiplier = 0.04f; } }
public class Multi005_Raw : RawBuff { public Multi005_Raw() { BaseMultiplier = 0.05f; } }