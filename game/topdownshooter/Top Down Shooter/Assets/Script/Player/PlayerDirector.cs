using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirector : MonoBehaviour
{
    GameObject m_player;
    public GameObject m_magic1;
    public GameObject m_magic2;
    int m_manaFrame;
    int m_strengthFrame;
    bool m_reCharge;
    public float m_dps;//連射速度
    public int m_maxManaPoint;//最大マナ量
    public int m_manaPoint;//現在のマナ量
    public int m_maxStrengthPoint;//最大スタミナ量
    public int m_strengthPoint;//現在のスタミナ量
    public int m_manaRecoveryValue;//マナ自然回復量
    public int m_strengthRecoveryValue;//スタミナ自然回復量

    // Start is called before the first frame update
    void Start()
    {
        m_dps = 0.25f;
        m_reCharge = false;
        m_maxManaPoint = 100;
        m_manaPoint = 100;
        m_maxStrengthPoint = 100;
        m_strengthPoint = 100;
        m_manaRecoveryValue = 1;
        m_strengthRecoveryValue = 1;
        m_player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (m_manaPoint > 0)
        {
            if (Input.GetMouseButton(0))//攻撃１
            {
                if (m_reCharge == false)
                {
                    Instantiate(m_magic1, m_player.transform.position + m_player.transform.forward * 0.65f, m_player.transform.rotation);
                    m_manaPoint -= 1;
                    m_reCharge = true;
                    Invoke(nameof(ReCharge), m_dps);
                }
            }
        }
        if (m_manaPoint > 9)
        {
            if (Input.GetMouseButtonDown(1))//攻撃２
            {
                Instantiate(m_magic2, m_player.transform.position + m_player.transform.forward * 0.6f, m_player.transform.rotation);
                m_manaPoint -= 10;
            }
        }
    }
    void FixedUpdate()//時間経過で回復するもの
    {
        m_manaFrame += 1;
        if (m_manaFrame == 50)
        {
            if (m_manaPoint < m_maxManaPoint)
            {
                m_manaPoint += m_manaRecoveryValue;
            }
            if (m_manaPoint > m_maxManaPoint)
            {
                m_manaPoint = m_maxManaPoint;
            }
            m_manaFrame = 0;
        }
        m_strengthFrame += 1;
        if (m_strengthFrame == 10)
        {
            if (m_strengthPoint < m_maxStrengthPoint)
            {
                m_strengthPoint += m_strengthRecoveryValue;
            }
            if (m_strengthPoint > m_maxStrengthPoint)
            {
                m_strengthPoint = m_maxStrengthPoint;
            }
            m_strengthFrame = 0;
        }
    }

    void ReCharge()
    {
        m_reCharge = false;
    }

    public void UseStrengthPoint20()
    {
        m_strengthPoint -= 20;
    }

    public void Stop()
    {
        m_manaPoint = 0;
        m_strengthPoint = 0;
    }

    public void StoreDPS()
    {
        m_dps *= 0.9f;
    }

    public void StoreTotalMana()
    {
        m_maxManaPoint += 25;
    }

    public void StoreTotalStrength()
    {
        m_maxStrengthPoint += 25;
    }

    public void StoreManarecovery()
    {
        m_manaRecoveryValue += 1;
    }

    public void StoreStrengthRecovery()
    {
        m_strengthRecoveryValue += 1;
    }
}
