using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 1)]
public class PlayerData : ScriptableObject
{
    public int g_wood;
    public int g_stone;
    public float g_environmentalDestruction;
    public int g_nowWave;
    public bool g_playerWin;
    public float g_time;

    public Dictionary<string, bool> UnLockData;

    public void Initialize()
    {
        g_wood = 0;
        g_stone = 0;
        g_environmentalDestruction = 0;
        g_nowWave = 0;
        g_playerWin = false;
        g_time = 0;
    }
}
