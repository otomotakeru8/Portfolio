using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TowerConstant;
using static Utilities;
using System;
using System.Runtime.CompilerServices;

public class Tower : MonoBehaviour
{
    [SerializeField]
    PlayerData m_playerData;

    //ステータス
    [SerializeField]
    TowerStatus[] m_towerStatus;
    public int m_towerLevel { get; private set;}
    public float m_rechargeTime { get; private set; }
    public bool m_onReCherge { get; set; }
    public float m_range { get; private set; }
    public int m_capacity { get; private set; }
    public float m_spread { get; private set; }
    public int m_buyPrice { get; private set; }

    Launcher m_launcher;
    GameObject m_towerAppearance;

    //セットされたタレントを格納する場所
    TalentBase[] m_talentBases;
    [SerializeField]
    TalentList m_talentList;

    //カードゲームベースの発射管理
    [HideInInspector]
    public List<TalentBase> m_deck;
    [HideInInspector]
    public List<TalentBase> m_hand;
    [HideInInspector]
    public List<TalentBase> m_discard;

    //発射管理用
    float m_resultRechergeTime;
    int m_drawSize;
    int m_drawTalentNumber;
    int m_shotTalentNumber;
    int m_modifierCount;

    //UI
    [SerializeField]
    GameObject m_towerUI;
    bool m_onDisplay = false;
    GameObject m_uiObject;
    GameObject m_canvas;
    [SerializeField]
    TowerData m_towerData;

    // Start is called before the first frame update
    void Start()
    {
        m_launcher = transform.Find("Launcher").gameObject.GetComponent<Launcher>();
        TowerInitialize();
        DeckInitialize();
        m_canvas = GameObject.Find("Canvas");
    }

    //初期化、レベルアップ時
    void TowerInitialize()
    {
        if (m_towerLevel == 0) m_towerLevel = 1;
        m_rechargeTime = m_towerStatus[m_towerLevel - 1].rechergeTime;
        m_range = m_towerStatus[m_towerLevel - 1].range;
        m_capacity = m_towerStatus[m_towerLevel - 1].capacity;
        m_spread = m_towerStatus[m_towerLevel - 1].spread;
        m_buyPrice = m_towerStatus[m_towerLevel - 1].buyPrice;
        TalentBase[] tmp_talentBases = new TalentBase[m_capacity];
        m_talentBases?.CopyTo(tmp_talentBases,0);
        m_talentBases = new TalentBase[m_capacity];
        m_talentBases = tmp_talentBases;
        DestroyImmediate(m_towerAppearance);
        m_towerAppearance = Instantiate(m_towerData.g_towerList[m_towerLevel - 1], transform);
        m_launcher.SetRange(m_range);
    }

    //初期化、リロード時
    void DeckInitialize()
    {
        m_deck = new List<TalentBase>(m_talentBases);
        m_deck.RemoveAll(item => item == null);
        m_hand = new List<TalentBase>();
        m_discard = new List<TalentBase>();
        m_shotTalentNumber = 0;
    }

    public void SetTalent(string[] name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (CheckNullData(name[i]) == true)
            {
                m_talentBases[i] = null;
                continue;
            }
            foreach (TalentBase talentBaseAsset in m_talentList.talentBases)
            {
                if (name[i].Contains(talentBaseAsset.m_talentName))
                {
                    m_talentBases[i] = talentBaseAsset;
                }
            }
        }
        DeckInitialize();
    }

    public string[] GetTalentName()
    {
        string[] resultsstring = new string[m_talentBases.Length];
        if (ArrayContentsValue(m_talentBases) != 0)
        {
            for (int i = 0; i < m_talentBases.Length; i++)
            {
                if (CheckNullData(m_talentBases[i]) == true)
                {
                    continue;
                }
                resultsstring[i] = m_talentBases[i].m_talentName;
            }
        }
        return resultsstring;
    }

    public void DrawAction(int how_many, [CallerMemberName] string callerMethodName = "")
    {
        for (int i = 0; i < how_many; i++)
        {
            int multiCastValue = 0;
            if (m_deck.Count > 0)
            {
                multiCastValue = m_deck[0].m_multiCastValue;
                DeckToHand();
            }
            else if (callerMethodName.Equals("DrawAction"))
            {
                if (m_discard.Count > 0)
                {
                    multiCastValue = m_discard[0].m_multiCastValue;
                    DiscardToHand();
                }
            }
            //マルチキャスト
            if (multiCastValue > 0)
            {
                DrawAction(multiCastValue);
            }
        }
    }

    void DeckToHand()
    {
        m_hand.Add(m_deck[0]);
        m_deck.RemoveAt(0);
    }

    void HandToDiscard()
    {
        m_discard.Add(m_hand[0]);
        m_hand.RemoveAt(0);
    }

    void DeckToDiscard()
    {
        m_discard.Add(m_deck[0]);
        m_deck.RemoveAt(0);
    }

    void DiscardToHand()
    {
        m_hand.Add(m_discard[0]);
        m_discard.RemoveAt(0);
    }

    public void PlayAction()
    {
        float rechargeTime = m_rechargeTime;
        float spread = m_spread;

        foreach (TalentBase talentBase in m_hand)
        {
            if (CheckNullData(talentBase) == true)
            {
                continue;
            }
            if (talentBase.m_shooterInformation == 0)
            {
                rechargeTime += talentBase.m_addRechergeTime;
                spread += talentBase.m_spread;
            }
        }
        m_launcher.ShotAction(m_hand, spread);
        while (m_hand.Count > 0)
        {
            HandToDiscard();
        }
        Invoke(nameof(Recherge), rechargeTime);
    }

    public void TowerLevelUp()
    {
        if (m_towerLevel < maxTowerLevel)
        {
            m_towerLevel++;
            TowerInitialize();
        }
    }

    public int GetLevelUpCost()
    {
        int cost = 0;
        if (m_towerLevel < maxTowerLevel)
        {
            cost = m_towerStatus[m_towerLevel].upgradeCost;
        }
        return cost;
    }

    public void Recherge()
    {
        m_onReCherge = false;
        if (m_deck.Count == 0)
        {
            DeckInitialize();
        }
    }

    public void UIStateChange()
    {
        if (m_onDisplay == true)
        {
            Destroy(m_uiObject);
        }
        else
        {
            m_uiObject = Instantiate(m_towerUI, m_canvas.transform);
        }
    }

    public void UIDisable()
    {
        Destroy(m_uiObject);
    }

    public void Destroy()
    {
        m_playerData.g_wood += 2;
        m_playerData.g_stone += m_buyPrice;
        UIDisable();
        Destroy(this.gameObject);
    }
}
