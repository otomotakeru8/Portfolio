using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricShock : MonoBehaviour
{
    Talent m_talent;

    /*
    [SerializeField]
    float m_chainRadius;
    [SerializeField]
    int m_chainLimit;
    int m_chainCount;

    Searcher m_searcher = new Searcher();
    */

    // Start is called before the first frame update
    void Start()
    {
        m_talent = GetComponent<Talent>();
        m_talent.m_triggerHit += Chain;
        m_talent.AddEvent(EffectConstant.StatusEffect.electric);
    }

    void Chain()
    {
        //余裕があったら連鎖させたい
        //GameObject[] nearbyEnemies = m_Searcher.SearchObjectsByTag(transform.position, 1, "Enemy");
        Destroy(gameObject);
    }
}
