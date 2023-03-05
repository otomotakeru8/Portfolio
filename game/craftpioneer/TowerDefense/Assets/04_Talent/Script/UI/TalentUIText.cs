using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static TalentConstant;

public class TalentUIText : MonoBehaviour
{
    [SerializeField]
    TalentList m_talentList;
    static TalentBase[] s_talentBases;

    private void Start()
    {
        s_talentBases = new TalentBase[m_talentList.talentBases.Count];
        Array.Copy(m_talentList.talentBases.ToArray(), s_talentBases, m_talentList.talentBases.Count);
    }

    public static string GenerateTalentUIText(string talentName)
    {
        string description;
        string type;
        string damage;
        string addReChergeTime;
        string multicast;
        string resultText = "";
        talentName = talentName.Remove(talentName.Length - 7);
        foreach (TalentBase talentBase in s_talentBases)
        {
            if(talentName.Equals(talentBase.m_talentName) == true)
            {
                switch (talentBase.m_talentType)
                {
                    case TalentType.Projectile:
                        talentName = talentName.Insert(0, talentName[0].ToString().ToLower()).Remove(1, 1);
                        type = Translation.GetTranslationText("type") + ":" + Translation.GetTranslationText("projectile");
                        description = Translation.GetTranslationText(talentName + "description");
                        damage = Translation.GetTranslationText("damage") + ":" + talentBase.m_damage.ToString();
                        addReChergeTime = Translation.GetTranslationText("addrechergetime") + ":" + talentBase.m_addRechergeTime.ToString();
                        resultText = $"{type}\n{description}\n{damage}\n{addReChergeTime}";
                        break;
                    case TalentType.Modifier:
                        talentName = talentName.Insert(0, talentName[0].ToString().ToLower()).Remove(1, 1);
                        type = Translation.GetTranslationText("type") + ":" + Translation.GetTranslationText("modifier");
                        description = Translation.GetTranslationText(talentName + "description");
                        multicast = Translation.GetTranslationText("multicast") + ":" + talentBase.m_multiCastValue.ToString();
                        addReChergeTime = Translation.GetTranslationText("addrechergetime") + ":" + talentBase.m_addRechergeTime.ToString();
                        resultText = $"{type}\n{description}\n{multicast}\n{addReChergeTime}";
                        break;
                    case TalentType.Material:
                        talentName = talentName.Insert(0, talentName[0].ToString().ToLower()).Remove(1, 1);
                        type = Translation.GetTranslationText("type") + ":" + Translation.GetTranslationText("material");
                        description = Translation.GetTranslationText(talentName + "description");
                        multicast = Translation.GetTranslationText("multicast") + ":" + talentBase.m_multiCastValue.ToString();
                        addReChergeTime = Translation.GetTranslationText("addrechergetime") + ":" + talentBase.m_addRechergeTime.ToString();
                        resultText = $"{type}\n{description}\n{multicast}\n{addReChergeTime}";
                        break;
                    case TalentType.StaticProjectile:

                        break;
                    case TalentType.Utility:

                        break;
                }
            }
        }

        return resultText;
    }
}
