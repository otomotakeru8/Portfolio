using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField]
    SettingsData settingsData;

    Translation translation;
    private void Start()
    {
        translation = FindObjectOfType<Translation>();
    }

    public void SetTranslationCountry(int value)
    {
        settingsData.translationLanguages = value;
        translation.Initialize();
    }
}
