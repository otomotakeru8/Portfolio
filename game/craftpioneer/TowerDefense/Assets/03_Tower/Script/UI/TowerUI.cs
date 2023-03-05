using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TowerUI : MonoBehaviour
{
    [SerializeField]
    TowerData m_towerData;
    [SerializeField]
    TalentList m_talentList;
    [SerializeField]
    GameObject m_talentFrameUI;
    GameObject[] m_capacityObject;
    string[] m_contentsArray;

    const float m_farstTalentFramePosX = -350f;
    const float m_talentFrameDistance = 100f;

    [SerializeField]
    GameObject m_circleObject;

    Tower m_tower;
    GameObject m_towerObject;
    GameObject m_rangeCircle;

    Text m_levelText;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        TowerManager m_towerManager = GameObject.Find("Tower").GetComponent<TowerManager>();
        if (m_towerManager.m_selectTower != null)
        {
            m_towerObject = m_towerManager.m_selectTower;
        }
        else
        {
            m_towerObject = m_towerManager.m_lateSelectTower;
        }
        m_tower = m_towerObject.GetComponent<Tower>();
        m_capacityObject = new GameObject[m_tower.m_capacity];
        m_contentsArray = new string[m_tower.m_capacity];
        string[] talentName = m_tower.GetTalentName();
        for (int i = 0; i < talentName.Length; i++)
        {
            m_contentsArray[i] = talentName[i];
        }
        Transform capacity = transform.Find("Capacity");
        for (int i = 0; i < capacity.childCount; i++)
        {
            Destroy(capacity.GetChild(i).gameObject);
        }
        for (int i = 0; i < m_capacityObject.Length; i++)
        {
            m_capacityObject[i] = Instantiate(m_talentFrameUI, capacity);
            m_capacityObject[i].GetComponent<RectTransform>().localPosition = new Vector3(m_farstTalentFramePosX + (i * m_talentFrameDistance), 0, 0);
        }
        for (int i = 0; i < m_contentsArray.Length; i++)
        {
            foreach (GameObject talentUI in m_talentList.talentUIObject)
            {
                if (talentUI.name.Equals(m_contentsArray[i]))
                {
                    GameObject instanceObject = Instantiate(talentUI, m_capacityObject[i].transform);
                    m_capacityObject[i].GetComponent<TalentFrameUI>().DontReroadSetTalent(instanceObject);
                }
            }
        }
        if (m_rangeCircle == null)
        {
            m_rangeCircle = Instantiate(m_circleObject, m_towerObject.transform.position + (Vector3.up * 0.01f), Quaternion.identity);
            m_rangeCircle.transform.localScale = 2 * m_tower.m_range * Vector3.one;
        }
        else
        {
            m_rangeCircle.transform.localScale = 2 * m_tower.m_range * Vector3.one;
        }
        m_levelText = transform.Find("LevelText").GetComponent<Text>();
        m_levelText.text = $"Level:{m_tower.m_towerLevel}";
    }

    public void CapacityDataCompletion()
    {
        for (int i = 0; i < m_capacityObject.Length; i++)
        {
            if (m_capacityObject[i].transform.childCount > 0)
            {
                m_contentsArray[i] = m_capacityObject[i].GetComponent<TalentFrameUI>().GetTalent().name;
            }
            else
            {
                m_contentsArray[i] = null;
            }
        }
        m_tower.SetTalent(m_contentsArray);
    }

    private void Update()
    {
        if (m_tower == null)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        Destroy(m_rangeCircle);
    }
}
