using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerStatus", menuName = "ScriptableObjects/TowerStatus", order = 1)]
public class TowerStatus : ScriptableObject
{
    public string statusName;
    public float rechergeTime;
    public float range;
    public int capacity;
    public float spread;
    public int upgradeCost;
    public int buyPrice;
}
