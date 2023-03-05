using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    PlayerData m_playerData;
    [SerializeField]
    TalentList m_talentList;
    [SerializeField]
    GameObject m_winText;
    [SerializeField]
    GameObject m_loseText; 

    float m_startTime;

    private void Awake()
    {
        m_playerData.Initialize();
        CreateUnLockData();
        m_playerData.UnLockData["Arrow"] = true;
        m_playerData.UnLockData["Bomb"] = true;
    }

    private void Start()
    {
        m_startTime = Time.time;
    }

    private void Update()
    {
        m_playerData.g_time = Time.time - m_startTime;
    }

    void CreateUnLockData()
    {
        m_playerData.UnLockData = new Dictionary<string, bool>();
        foreach (TalentBase talentBase in m_talentList.talentBases)
        {
            m_playerData.UnLockData.Add(talentBase.m_talentName, false);
        }
    }

    public void RandomUnLock()
    {
        int lockCount = 0;
        List<string> lockDataName = new List<string>();
        foreach (KeyValuePair<string, bool> unLockData in m_playerData.UnLockData)
        {
            if (unLockData.Value == false)
            {
                lockDataName.Add(unLockData.Key);
                lockCount++;
            }
        }
        int rand = UnityEngine.Random.Range(0, lockCount);
        m_playerData.UnLockData[lockDataName[rand]] = true;

        this.gameObject.GetComponent<TextUI>().GetTalentPanel();
    }

    public void PlayerWin()
    {
        m_winText.SetActive(true);
        m_playerData.g_playerWin = true;
        Invoke(nameof(LoadingResult), 3);
    }

    public void PlayerLose()
    {
        m_loseText.SetActive(true);
        m_playerData.g_playerWin = false;
        Invoke(nameof(LoadingResult), 3);
    }

    void LoadingResult()
    {
        Loading.Scenename = "Resultscene";
        Loading.instance.NextScene();
    }
}
