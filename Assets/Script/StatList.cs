using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스텟목록

//순서대로 최대체력, 최대마나, 현재체력, 현재마나
public class MaxHP : Stat { }
public class MaxMP : Stat { }
public class HP : Stat { }
public class MP : Stat { }

//순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
public class Strength : Stat { }
public class Magic : Stat { }
public class PhysicalAtk : Stat { }
public class MagicAtk : Stat { }
public class Defense : Stat { }
public class Resistance : Stat { }

//순서대로 회피, 적중률, 크리확률, 크리배수
public class Evade : Stat { }
public class Accuracy : Stat { }
public class CritChance : Stat { }
public class CritMultiplier : Stat { }

public class MoveSpeed : Stat { }
public class EXP : Stat { }
public class Level : Stat { }

