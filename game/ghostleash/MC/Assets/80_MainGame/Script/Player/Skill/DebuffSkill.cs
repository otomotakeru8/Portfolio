using System;
using UnityEngine;
using static Constant;

[Serializable]
public class DebuffSkill
{
    public enum DebuffType
    {
        Speed,
        AddDamage,
        Attack,
    }
    public DebuffType m_debuffType;
    public float m_ratio;
    public TimerData m_timerData;
}
