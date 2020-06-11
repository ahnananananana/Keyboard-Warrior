using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스텟목록

//순서대로 최대체력, 최대마나, 현재체력, 현재마나
public class MaxHP : Stat { public MaxHP(float basevalue = 1, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class MaxMP : Stat { public MaxMP(float basevalue = 1, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class HP : Stat { public HP(float basevalue = 1, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class MP : Stat { public MP(float basevalue = 1, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }

//순서대로 힘, 마법, 물리공격력, 마법공격력, 물리방어, 마법방어
public class Strength : Stat { public Strength(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class Magic : Stat { public Magic(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class PhysicalAtk : Stat { public PhysicalAtk(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class MagicAtk : Stat { public MagicAtk(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class Defense : Stat { public Defense(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class Resistance : Stat { public Resistance(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }

//순서대로 회피, 적중률, 크리확률, 크리배수
public class Evade : Stat { public Evade(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class Accuracy : Stat { public Accuracy(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class CritChance : Stat { public CritChance(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class CritMultiplier : Stat { public CritMultiplier(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }

public class MoveSpeed : Stat { public MoveSpeed(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class EXP : Stat { public EXP(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }
public class Level : Stat { public Level(float basevalue = 0, float basemultiplier = 0) { BaseValue = basevalue; BaseMultiplier = basemultiplier; } }

