using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SettingsData", menuName = "ScriptableObjects/SettingsData", order = 1)]
public class SettingsData : ScriptableObject
{
    [Range(0, 1)]
    public float bgmVolume;
    [Range(0, 1)]
    public float seVolume;
    public int translationLanguages;
    public bool debug_doubleTextMode;
}
