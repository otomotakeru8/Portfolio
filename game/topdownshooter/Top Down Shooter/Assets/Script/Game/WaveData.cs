using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "WaveData", menuName = "ScriptableObjects/WaveData", order = 1)]
public class WaveData : ScriptableObject
{
    public Wave[] waves;
}

[Serializable]
public class Wave
{
    public GenerateEnemyData[] m_generateEnemyDatas;
}

[Serializable]
public class GenerateEnemyData
{
    public int m_minEnemyLevel;
    public int m_maxEnemyLevel;
}
