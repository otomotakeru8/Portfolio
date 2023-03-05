using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TalentList", menuName = "ScriptableObjects/TalentList", order = 1)]

public class TalentList : ScriptableObject
{
    [SerializeField]
    public List<TalentBase> talentBases = new List<TalentBase>();
    [SerializeField]
    public List<GameObject> talentUIObject = new List<GameObject>();
}
