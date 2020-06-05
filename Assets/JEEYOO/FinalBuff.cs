using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBuff : Stat
{
    public Add10_Final add10;
    public Add20_Final add20;
    public Add30_Final add30;
    public Add40_Final add40;
    public Add50_Final add50;
    public Add100_Final add100;
    public Add150_Final add150;

    public Multi001_Final multi001;
    public Multi002_Final multi002;
    public Multi003_Final multi003;
    public Multi004_Final multi004;
    public Multi005_Final multi005;
}

public class Add10_Final : FinalBuff { public Add10_Final() { BaseValue = 10; } }
public class Add20_Final : FinalBuff { public Add20_Final() { BaseValue = 20; } }
public class Add30_Final : FinalBuff { public Add30_Final() { BaseValue = 30; } }
public class Add40_Final : FinalBuff { public Add40_Final() { BaseValue = 40; } }
public class Add50_Final : FinalBuff { public Add50_Final() { BaseValue = 50; } }
public class Add100_Final : FinalBuff { public Add100_Final() { BaseValue = 100; } }
public class Add150_Final : FinalBuff { public Add150_Final() { BaseValue = 150; } }

public class Multi001_Final : FinalBuff { public Multi001_Final() { BaseMultiplier = 0.01f; } }
public class Multi002_Final : FinalBuff { public Multi002_Final() { BaseMultiplier = 0.02f; } }
public class Multi003_Final : FinalBuff { public Multi003_Final() { BaseMultiplier = 0.03f; } }
public class Multi004_Final : FinalBuff { public Multi004_Final() { BaseMultiplier = 0.04f; } }
public class Multi005_Final : FinalBuff { public Multi005_Final() { BaseMultiplier = 0.05f; } }