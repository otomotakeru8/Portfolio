using System;
using UnityEngine;
using static Constant;

[Serializable]

public class BuffSkill
{
    public enum BuffType
    {
        Healing,
        AddAttackSpeed,
    }
    public BuffType m_buffType;
    public float m_ratio;
    public float m_increaseRatio;
    public TimerData m_timerData;
}
