using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalentFrameUI : MonoBehaviour
{
    GameObject m_talent;
    bool m_canStack;
    public bool CanStack { get { return m_canStack;} set { m_canStack = value;} }
    int m_stack = 0;
    public int Stack { get { return m_stack;} set { m_stack = value;} }

    public bool m_infinite;
    public bool m_destroy;

    public void SetTalent(GameObject gameObject)
    {
        m_stack++;
        m_talent = gameObject;
        if (m_destroy == true)
        {
            m_stack = 0;
            m_talent = null;
            Destroy(transform.GetChild(0).gameObject);
            if (transform.parent.TryGetComponent(out TowerUI towerui))
            {
                towerui.CapacityDataCompletion();
            }
        }
        if (transform.parent.parent.TryGetComponent(out TowerUI towerUi))
        {
            towerUi.CapacityDataCompletion();
        }
    }

    public void DontReroadSetTalent(GameObject gameObject)
    {
        m_stack++;
        m_talent = gameObject;
    }

    public GameObject GetTalent()
    {
        return m_talent;
    }

    public void TakeTalent()
    {
        if (m_infinite == true)
        {
            Instantiate(m_talent, transform);
        }
        else
        {
            m_stack--;
        }
        if (m_stack == 0)
        {
            m_talent = null;
        }
        transform.parent.GetComponent<TowerUI>()?.CapacityDataCompletion();
    }
}
