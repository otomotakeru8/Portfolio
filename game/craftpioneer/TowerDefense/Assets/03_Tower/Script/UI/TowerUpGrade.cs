using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerUpGrade : MonoBehaviour
{
    [SerializeField]
    PlayerData m_playerData;
    [SerializeField]
    TowerData m_towerData;

    Tower m_tower;

    Button m_button;
    Text m_text;

    // Start is called before the first frame update
    void Start()
    {
        m_tower = GameObject.Find("Tower").GetComponent<TowerManager>().m_selectTower.GetComponent<Tower>();
        m_button = GetComponent<Button>();
        m_text = transform.GetChild(0).GetComponent<Text>();
        m_text.text = $"{Translation.GetTranslationText("upgrade")}";
        DisplayText();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayText();
    }

    void DisplayText()
    {
        if (m_tower.GetLevelUpCost() == 0 || m_tower.GetLevelUpCost() > m_playerData.g_stone)
        {
            m_button.interactable = false;
        }
        else
        {
            if (m_button.interactable == false)
            {
                m_button.interactable = true;
            }
            m_text.text = $"{Translation.GetTranslationText("upgrade")} {m_tower.GetLevelUpCost()}";
        }
    }

    public void UpGrade()
    {
        m_playerData.g_stone -= m_tower.GetLevelUpCost();
        m_tower.TowerLevelUp();
        transform.parent.gameObject.GetComponent<TowerUI>().Initialize();
    }
}
