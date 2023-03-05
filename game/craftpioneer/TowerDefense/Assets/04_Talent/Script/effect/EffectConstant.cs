using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectConstant
{
    public const int statusEffectInterval = 30;
    public const int statusEffectRemoveSec = 2;

    public const int effectMaxValue = 100;

    public enum StatusEffect
    {
        fire,
        toxic,
        electric,
        ice,
    }

    public const int fireDamagePercent = 7;
    public const int toxicDamagePercent = 7;
    public const int electricDamagePercent = 14;
}
