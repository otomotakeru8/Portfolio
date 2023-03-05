using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnemyConstant;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData", order = 1)]
public class EnemyData : ScriptableObject
{
    public string m_enemyName;
    public int m_hp;
    public float m_speed;
    public float m_projectileDamageMultiplier;
    public float m_fireDamageMultiplier;
    public float m_toxicDamageMultiplier;
    public float m_electricityDamageMultiplier;
    public float m_iceDamageMultiplier;
    public float m_magicDamageMultiplier;
    public EnemyType m_enemyType;

    public void DeepCopy(EnemyData enemyData)
    {
        m_enemyName = enemyData.m_enemyName;
        m_hp = enemyData.m_hp;
        m_speed = enemyData.m_speed;
        m_projectileDamageMultiplier = enemyData.m_projectileDamageMultiplier;
        m_fireDamageMultiplier = enemyData.m_fireDamageMultiplier;
        m_toxicDamageMultiplier = enemyData.m_toxicDamageMultiplier;
        m_electricityDamageMultiplier = enemyData.m_electricityDamageMultiplier;
        m_iceDamageMultiplier = enemyData.m_iceDamageMultiplier;
        m_magicDamageMultiplier = enemyData.m_magicDamageMultiplier;
        m_enemyType = enemyData.m_enemyType;
    }
}
