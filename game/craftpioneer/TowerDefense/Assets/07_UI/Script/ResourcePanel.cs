using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcePanel : MonoBehaviour
{
    [SerializeField]
    PlayerData m_playerData;

    Text m_woodText;
    Text m_stoneText;
    CustomAnimation m_woodCustomAnimation;
    CustomAnimation m_stoneCustomAnimation;
    int m_lateWood;
    int m_lateStone;

    // Start is called before the first frame update
    void Start()
    {
        m_woodText = transform.Find("Wood/Text").GetComponent<Text>();
        m_stoneText = transform.Find("Stone/Text").GetComponent<Text>();
        m_woodCustomAnimation = transform.Find("Wood").GetComponent<CustomAnimation>();
        m_stoneCustomAnimation = transform.Find("Stone").GetComponent<CustomAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        m_woodText.text = $"{Translation.GetTranslationText("wood")} {m_playerData.g_wood}";
        m_stoneText.text = $"{Translation.GetTranslationText("stone")} {m_playerData.g_stone}";
        if (m_playerData.g_wood > m_lateWood)
        {
            m_woodCustomAnimation.m_baseAnimationSpeed = 3;
        }
        if (m_playerData.g_stone > m_lateStone)
        {
            m_stoneCustomAnimation.m_baseAnimationSpeed = 3;
        }
        m_lateWood = m_playerData.g_wood;
        m_lateStone = m_playerData.g_stone;
    }
}
