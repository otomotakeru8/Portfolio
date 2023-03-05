using System;
using UnityEngine;
using static Constant;

[Serializable]
public class AttackSkill
{
    public enum DamageResource
    {
        BaseAttackPower,
        PhysicsDamageResistance
    }
    public DamageResource m_damageResource;
    public DamageType m_damageType;
    public double m_damageMagnification;
    public double m_increaseDamageMagnification;
    public TimerData m_timerData;
}
