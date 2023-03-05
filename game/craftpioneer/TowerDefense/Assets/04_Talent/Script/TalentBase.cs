using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TalentConstant;
using static EnemyConstant;

[CreateAssetMenu(fileName = "TalentBase", menuName = "ScriptableObjects/TalentBase", order = 1)]
public class TalentBase : ScriptableObject
{
    public string m_talentName;
    public TalentType m_talentType;
    public TalentAttribute m_talentAttribute;
    public int m_damage;
    public int m_criticalChance;
    public float m_speed;
    public float m_addRechergeTime;
    public int m_multiCastValue;
    public float m_lifeTime;
    public float m_spread;
    public bool m_pierceing;
    [Range(0,1)]
    public float m_airResistance;
    public float m_massScale;
    [HideInInspector]
    public int m_shooterInformation;

    public void DeepCopy(TalentBase talentBase)
    {
        m_talentName = talentBase.m_talentName;
        m_talentType = talentBase.m_talentType;
        m_talentAttribute = talentBase.m_talentAttribute;
        m_damage = talentBase.m_damage;
        m_criticalChance = talentBase.m_criticalChance;
        m_speed = talentBase.m_speed;
        m_addRechergeTime = talentBase.m_addRechergeTime;
        m_multiCastValue = talentBase.m_multiCastValue;
        m_lifeTime = talentBase.m_lifeTime;
        m_spread = talentBase.m_spread;
        m_airResistance = talentBase.m_airResistance;
        m_massScale = talentBase.m_massScale;
        m_shooterInformation = talentBase.m_shooterInformation;
    }
}
