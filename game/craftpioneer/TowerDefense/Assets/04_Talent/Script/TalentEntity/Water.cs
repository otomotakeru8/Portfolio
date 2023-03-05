using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    Talent m_talent;

    // Start is called before the first frame update
    void Start()
    {
        m_talent = GetComponent<Talent>();
        m_talent.m_triggerHit += AddWet;
    }

    void AddWet()
    {
        Searcher searcher = new Searcher();
        GameObject[] targets = searcher.SearchObjectsByTag(transform.position, 1, "Enemy");
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].GetComponent<Enemy>().AddEffect_Wet();
        }
    }
}
