using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    [SerializeField]
    PlayerData m_playerData;
    [SerializeField]
    TowerData m_towerData;

    TowerManager m_towerManager;
    Tower m_tower;
    Text m_text;

    // Start is called before the first frame update
    void Start()
    {
        m_towerManager = GameObject.Find("Tower").GetComponent<TowerManager>();
        if (m_towerManager.m_selectTower != null)
        {
            m_tower = m_towerManager.m_selectTower.GetComponent<Tower>();
        }
        else
        {
            m_tower = m_towerManager.m_lateSelectTower.GetComponent<Tower>();
        }
        m_text = transform.GetChild(0).GetComponent<Text>();
        DisplayText();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayText();
    }

    void DisplayText()
    {
        m_text.text = $"{Translation.GetTranslationText("buy")} {m_tower.m_buyPrice}";
    }

    public void OnBuy()
    {
        MapCreator mapCreator = GameObject.Find("Map").GetComponent<MapCreator>();
        GameObject ground = mapCreator.GroundAddress[(int)m_towerManager.m_lateSelectTower.transform.position.x, (int)m_towerManager.m_lateSelectTower.transform.position.z];
        ground.GetComponent<Ground>().onTower = false;
        m_tower.Destroy();
    }
}
