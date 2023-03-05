using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static Constant;

[CreateAssetMenu(fileName ="PlayerSkillData", menuName ="ScriptableObjects/PlayerSkillData", order =1)]
public class PlayerSkillData : ScriptableObject
{
    public bool m_originalAttackRange;
    public Vector2[] m_attackRange;
    public SkillTargetingType m_type;
    public bool m_stan;
    public TimerData m_stanTimeData;
    public AttackSkill[] m_attackSkill;
    public BuffSkill[] m_buffskill;
    public DebuffSkill[] m_debuffSkill;
    public GameObject m_summonObject;
    public bool m_knockBack;

    public enum SkillTargetingType
    {
        Attack,
        Support
    }
}
