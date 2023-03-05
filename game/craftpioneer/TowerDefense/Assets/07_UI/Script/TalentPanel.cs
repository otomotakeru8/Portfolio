using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class TalentPanel : MonoBehaviour
{
    [SerializeField]
    TalentList m_talentList;
    [SerializeField]
    PlayerData m_playerData;

    List<GameObject> m_talentsUI = new List<GameObject>();

    [SerializeField]
    GameObject m_talentFrame;

    const float m_farstTalentFramePosX = -640f;
    const float m_talentFrameDistance = 100f;
    // Start is called before the first frame update
    void Start()
    {
        PopTalents();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (? == true)
        {
            PopTalents();
        }
        */
    }

    public void PopTalents()
    {
        CheckTalnetsUnLock();
        int talentCount = m_talentsUI.Count;
        for (int i = 0; i < talentCount; i++)
        {
            GameObject frame = Instantiate(m_talentFrame, transform);
            frame.GetComponent<RectTransform>().localPosition = new Vector3(m_farstTalentFramePosX + (i * m_talentFrameDistance), 0, 0);
            TalentFrameUI talentFrameUI = frame.GetComponent<TalentFrameUI>();
            talentFrameUI.SetTalent(m_talentsUI[0]);
            talentFrameUI.m_infinite = true;
            Instantiate(m_talentsUI[0], frame.transform);
            m_talentsUI.RemoveAt(0);
        }
    }

    void CheckTalnetsUnLock()
    {
        foreach (TalentBase talentBase in m_talentList.talentBases)
        {
            if (m_playerData.UnLockData[talentBase.m_talentName] == true)
            {
                foreach (GameObject gameObject in m_talentList.talentUIObject)
                {
                    if (gameObject.name.Equals(talentBase.m_talentName) == true)
                    {
                        m_talentsUI.Add(gameObject);
                    }
                }
            }
        }
    }
}
